using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManager.Database;
using LibraryManager.FilteringService;
using LibraryManager.CRUDService;

namespace LibraryManager
{
    public partial class LibraryPanel : Form
    {
        private LoginWindow loginWindow;
        private DatabaseHandler databaseHandler;
        public LibraryPanel(LoginWindow loginWindow)
        {
            InitializeComponent();
            CenterToScreen();
            this.loginWindow = loginWindow;
            databaseHandler = new DatabaseHandler();
        }

        private void LibraryPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginWindow.Close();
        }

        private void btn_clear_filters_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cbx_exclude.Items.Count; ++i)
            {
                cbx_exclude.SetItemChecked(i, false);
            }

            tbx_from.Clear();
            tbx_to.Clear();
            cbx_currency.SelectedIndex = 0;

            UpdateVisuals();
        }

        private void UpdateVisuals(List<int> filteredBooksIds = null)
        {
            cbx_currency.Items.Clear();
            cbx_currency.Items.AddRange(databaseHandler.GetCurrencies().ToArray());
            cbx_currency.SelectedIndex = 0;

            cbx_exclude.Items.Clear();
            cbx_exclude.Items.AddRange(databaseHandler.GetCategories().ToArray());
            UpdateGridView(filteredBooksIds);

            cbx_edit_book.Items.Clear();
            cbx_edit_book.Items.AddRange(databaseHandler.GetBooksTitles().ToArray());
            cbx_edit_book.SelectedIndex = 0;

            cbx_delete.Items.Clear();
            cbx_delete.Items.AddRange(databaseHandler.GetBooksTitles().ToArray());
            cbx_delete.SelectedIndex = 0;

            cbx_edit_category.Items.Clear();
            cbx_edit_category.Items.AddRange(databaseHandler.GetCategories().ToArray());
            cbx_edit_category.SelectedIndex = 0;

            cbx_filter_author.Items.Clear();
            cbx_filter_author.Text = "";
            cbx_filter_author.Items.AddRange(databaseHandler.GetAuthors().ToArray());

            cbx_filter_by_user.Items.Clear();
            cbx_filter_by_user.Items.AddRange(databaseHandler.GetUsers().ToArray());

            if (loginWindow.loggedUserRole == LoginWindow.UserRole.USER)
            {
                UpdateBorrowedBooksGridView(loginWindow.loggedUserName);
                return;
            }
            UpdateBorrowedBooksGridView();
        }
        private void UpdateGridView(List<int> filteredBooksIds = null)
        {
            GV_books.Columns.Clear();
            var headers = databaseHandler.GetHeaders();
            GV_books.ColumnCount = headers.Length;

            foreach (DataGridViewColumn column in GV_books.Columns)
            {
                column.Name = headers[column.Index];
            }

            List<List<string>> books = databaseHandler.GetBooks(filteredBooksIds);
            foreach (var book in books)
            {
                GV_books.Rows.Add(book.ToArray());
            }
        }

        private void UpdateBorrowedBooksGridView(string user=null)
        {
            GV_borrowed.Columns.Clear();
            var header = new List<string>() { "user", "book", "Date of borrowing" };

            GV_borrowed.ColumnCount = header.Count;
            foreach (DataGridViewColumn column in GV_borrowed.Columns)
            {
                column.Name = header[column.Index];
            }

            List<List<string>> books = databaseHandler.GetBorrowedBooks(user);
            foreach (var book in books)
            {
                GV_borrowed.Rows.Add(book.ToArray());
            }
        }

        private void LibraryPanel_Load(object sender, EventArgs e)
        {    
            UpdateVisuals();
            if (loginWindow.loggedUserRole == LoginWindow.UserRole.GUEST)
            {
                tabControl1.TabPages.Remove(tabControl1.TabPages[1]);
                return;
            }
            
            if (loginWindow.loggedUserRole == LoginWindow.UserRole.USER)
            {
                NotifyUSer();
                groupBox1.Enabled = false;
               
                btn_filter_by_user.Click -= btn_filter_by_user_Click;
                btn_filter_by_user.Click += btn_borrrow_Click;
                btn_filter_by_user.Text = "Borrow book";

                btn_show_all.Click -= btn_show_all_Click;
                btn_show_all.Click += btn_return_book_Click;
                btn_show_all.Text = "Return book";

                UpdateUserVisualControls();
                return;
            }
            cbx_return_books.Hide();
            btn_show_borrowed.Hide();
            btn_show_history.Hide();
        }

        private void NotifyUSer()
        {
            List<List<string>> borrowedBooks = databaseHandler.GetBorrowedBooks(loginWindow.loggedUserName);
            List<string> booksToReturn = new List<string>();

            foreach( var book in borrowedBooks)
            {
                DateTime dateOfBorrowing = DateTime.Parse(book[book.Count - 1]);
                if (DateTime.Now <= dateOfBorrowing.AddDays(-2))
                {
                    booksToReturn.Add(book[1]);
                }
            }

            if (booksToReturn.Count != 0)
            {
                MessageBox.Show($"You have to return these books within 2 days:\n{String.Join("\n ", booksToReturn.ToArray())}");
            }
        }

        private void UpdateUserVisualControls()
        {
            cbx_filter_by_user.Text = "";
            cbx_return_books.Text = "";
            cbx_filter_by_user.Items.Clear();
            cbx_filter_by_user.Items.AddRange(databaseHandler.GetNamesOfUnborrowedBooks().ToArray());

            cbx_return_books.Items.Clear();
            List<string> bookTitles = new List<string>();
            foreach (var book in databaseHandler.GetBorrowedBooks(loginWindow.loggedUserName))
            {
                bookTitles.Add(book[1]);
            }

            cbx_return_books.Items.AddRange(bookTitles.ToArray());
        }

        private void btn_return_book_Click(object sender, EventArgs e)
        {
            if (cbx_return_books.SelectedItem == null)
            {
                MessageBox.Show("Choose a book");
                return;
            }

            using (var client = new CRUDServiceClient())
            {
                bool isReturned = client.DeleteBookFromBorrowed(loginWindow.loggedUserName, cbx_return_books.SelectedItem.ToString());
                if (!isReturned)
                {
                    MessageBox.Show("An error occurred during returing a book.");
                    return;
                }
                MessageBox.Show("Book has been returned");
                UpdateBorrowedBooksGridView(loginWindow.loggedUserName);
                UpdateUserVisualControls();
            }
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            List<int> filteredByCategory = databaseHandler.GetAllBooksIds();
            List<int> filteredByPrice = databaseHandler.GetAllBooksIds();
            List<int> filteredByState = databaseHandler.GetAllBooksIds();
            List<int> filteredByAuthor = databaseHandler.GetAllBooksIds();

            using (var client = new FilterBooksServiceClient())
            {
                if (cbx_exclude.CheckedItems.Count != 0)
                {
                    List<string> categories = new List<string>();

                    foreach (var item in cbx_exclude.CheckedItems)
                    {
                        categories.Add(item.ToString());
                    }
                    filteredByCategory = client.FilterByCategories(categories.ToArray()).AsEnumerable().ToList();
                }

                if (!VerifyTextBoxes())
                {
                    return;
                }

                if (!tbx_from.Text.Equals("") && !tbx_to.Text.Equals(""))
                {
                    filteredByPrice = client.FilterByPrice(
                        double.Parse(tbx_from.Text),
                        double.Parse(tbx_to.Text),
                        cbx_currency.SelectedItem.ToString())
                        .AsEnumerable()
                        .ToList();
                }
                
                filteredByState = client.FilterByState(cb_filter_borrowed.Checked).AsEnumerable().ToList();

                if (cbx_filter_author.SelectedItem != null)
                {
                    filteredByAuthor = client.FilterByAuthor(cbx_filter_author.SelectedItem.ToString())
                        .AsEnumerable().ToList();
                }

                List<int> mergedFilters = filteredByCategory
                    .AsQueryable()
                    .Intersect(filteredByPrice)
                    .Intersect(filteredByState)
                    .Intersect(filteredByAuthor)
                    .ToList();

                UpdateVisuals(mergedFilters);
            }
            
        }

        private bool VerifyTextBoxes()
        {
            double startRange;
            double endRange;

            if (tbx_from.Text.Equals("") && tbx_to.Text.Equals(""))
            {
                return true;
            }

            if ((tbx_from.Text.Equals("") && !tbx_to.Text.Equals("")) ||
                (!tbx_from.Text.Equals("") && tbx_to.Text.Equals("")))
            {
                MessageBox.Show("Fill price range to filter by price or leave it empty;");
                return false;
            }

            if (!double.TryParse(tbx_from.Text, out startRange) || !double.TryParse(tbx_to.Text, out endRange))
            {
                MessageBox.Show("Invalid price range.");
                return false;
            }

            if (endRange < startRange)
            {
                MessageBox.Show("End price cannot be lesser than start price.");
                return false;
            }

            return true;
        }

        private void btn_add_book_Click(object sender, EventArgs e)
        {
            string author = tbx_add_author.Text;
            string title = tbx_add_title.Text;
            string category = tbx_add_category.Text;
            string priceInString = tbx_add_price.Text;
            string currency = tbx_add_currency.Text;
            string pagesInString = tbx_add_pages.Text;

            if (author.Equals("") || title.Equals("") || category.Equals("")
                || priceInString.Equals("") || currency.Equals("") || pagesInString.Equals(""))
            {
                MessageBox.Show("Not Every field has been filled.");
                return;
            }

            if (databaseHandler.GetBooksTitles().Contains(title))
            {
                MessageBox.Show("The book with a given title already exists in the database.");
                return;
            }
            double price = 0;
            int pages = 0;

            if (!int.TryParse(tbx_add_pages.Text, out pages) 
                || !double.TryParse(tbx_add_price.Text, out price)
                || price <= 0 || pages <= 0)
            {
                MessageBox.Show("Incorrect price or number of pages.");
                return;
            }

            using (CRUDServiceClient client = new CRUDServiceClient())
            {
                bool isAdded = client.AddBook(author, title, price, currency, pages, category);

                if (!isAdded)
                {
                    MessageBox.Show("An error occured during inserting to database.");
                    return;
                }
                MessageBox.Show("Book has been added.");
                UpdateVisuals();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this book? ", "Deleting", 
                    MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            using (var client = new CRUDServiceClient())
            {
                bool isDeleted = client.DeleteBook(cbx_delete.SelectedItem.ToString());
                if (!isDeleted)
                {
                    MessageBox.Show("An error occured during deleting book.");
                    return;
                }
                MessageBox.Show("Book has been deleted.");
                UpdateVisuals();
            }
        }

        private void cbx_edit_book_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> bookProperties = databaseHandler.GetBookInfo(cbx_edit_book.SelectedItem.ToString());
            
            tbx_edit_name.Text = bookProperties[0];
            tbx_edit_author.Text = bookProperties[1];
            cbx_edit_category.SelectedIndex = cbx_edit_category.Items.IndexOf(bookProperties[2]);
            tbx_edit_price.Text = bookProperties[3];
            tbx_edit_currency.Text = bookProperties[4];
            tbx_edit_pages.Text = bookProperties[5];
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string author = tbx_edit_author.Text;
            string title = cbx_edit_book.SelectedItem.ToString();
            string newTitle = tbx_edit_name.Text;
            string category = cbx_edit_category.SelectedItem.ToString();
            string priceInString = tbx_edit_price.Text;
            string currency = tbx_edit_currency.Text;
            string pagesInString = tbx_edit_pages.Text;

            if (author.Equals("") || title.Equals("") || category.Equals("")
                || priceInString.Equals("") || currency.Equals("") || pagesInString.Equals(""))
            {
                MessageBox.Show("Not Every field has been filled.");
                return;
            }
            double price = 0;
            int pages = 0;

            if (!int.TryParse(tbx_edit_pages.Text, out pages)
                || !double.TryParse(tbx_edit_price.Text, out price)
                || price <= 0 || pages <= 0)
            {
                MessageBox.Show("Incorrect price or number of pages.");
                return;
            }

            using (var client = new CRUDServiceClient())
            {
                bool isUpdated = client.UpdateBook(title, newTitle, author, price, currency, pages, category);
                if (!isUpdated)
                {
                    MessageBox.Show("An error occured during updating book.");
                    return;
                }
                MessageBox.Show("Book has been updated.");
                UpdateVisuals();

            }
        }

        private void btn_add_books_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filePath = openFileDialog1.FileName;

            using (var client = new CRUDServiceClient())
            {
                bool success =  client.AddBooksFormJson(filePath);

                if (!success)
                {
                    MessageBox.Show("An error occured during adding books to a database. Check filepath and " +
                        "whether all fields in file are correct.");
                    return;
                }
                MessageBox.Show("Books has been updated.");
                UpdateVisuals();
            }
            
        }

        private void btn_filter_by_user_Click(object sender, EventArgs e)
        {
            if (cbx_filter_by_user.SelectedItem != null)
            {
                UpdateBorrowedBooksGridView(cbx_filter_by_user.SelectedItem.ToString());
                return;
            }
            UpdateBorrowedBooksGridView();
        }

        private void btn_show_all_Click(object sender, EventArgs e)
        {
            UpdateBorrowedBooksGridView();
        }

        private void btn_borrrow_Click(object sender, EventArgs e)
        {
            if (databaseHandler.GetBorrowedBooks(loginWindow.loggedUserName).Count == 3)
            {
                MessageBox.Show("You can only have 3 books borrowed at the same time. Please return these books" +
                    "if you want to borrow a new one.");
                return;
            }            

            using (var client = new CRUDServiceClient())
            {
                bool isAdded = client.AddBookToBorrowed(loginWindow.loggedUserName, cbx_filter_by_user.SelectedItem.ToString());

                if (!isAdded)
                {
                    MessageBox.Show("An error occured during borrowing a book.");
                    return;
                }
                MessageBox.Show("Books has been borrowed. You have to return book within 1 month.");
                UpdateBorrowedBooksGridView(loginWindow.loggedUserName);
                UpdateUserVisualControls();
            }
        }

        private void btn_show_history_Click(object sender, EventArgs e)
        {
            GV_borrowed.Columns.Clear();
            var header = new List<string>() { "book", "Date of borrowing", "Date of returning" };

            GV_borrowed.ColumnCount = header.Count;
            foreach (DataGridViewColumn column in GV_borrowed.Columns)
            {
                column.Name = header[column.Index];
            }

            List<List<string>> books = databaseHandler.GetReturnedBooks(loginWindow.loggedUserName);
            foreach (var book in books)
            {
                GV_borrowed.Rows.Add(book.ToArray());
            }
        }

        private void btn_show_borrowed_Click(object sender, EventArgs e)
        {
            UpdateBorrowedBooksGridView(loginWindow.loggedUserName);
        }
    }
}
