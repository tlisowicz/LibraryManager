
namespace LibraryManager
{
    partial class LibraryPanel
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.GV_books = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx_filter_author = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cb_filter_borrowed = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_currency = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_to = new System.Windows.Forms.TextBox();
            this.tbx_from = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_exclude = new System.Windows.Forms.CheckedListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_clear_filters = new System.Windows.Forms.Button();
            this.btn_apply = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbx_return_books = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cbx_filter_by_user = new System.Windows.Forms.ComboBox();
            this.GV_borrowed = new System.Windows.Forms.DataGridView();
            this.btn_show_all = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_add_title = new System.Windows.Forms.TextBox();
            this.tbx_add_author = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbx_edit_category = new System.Windows.Forms.ComboBox();
            this.btn_add_books = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbx_edit_book = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbx_delete = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbx_edit_pages = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbx_edit_currency = new System.Windows.Forms.TextBox();
            this.tbx_add_price = new System.Windows.Forms.TextBox();
            this.tbx_edit_price = new System.Windows.Forms.TextBox();
            this.tbx_add_currency = new System.Windows.Forms.TextBox();
            this.tbx_edit_author = new System.Windows.Forms.TextBox();
            this.tbx_add_pages = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.tbx_add_category = new System.Windows.Forms.TextBox();
            this.tbx_edit_name = new System.Windows.Forms.TextBox();
            this.btn_add_book = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_filter_by_user = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_show_history = new System.Windows.Forms.Button();
            this.btn_show_borrowed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GV_books)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_borrowed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GV_books
            // 
            this.GV_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_books.Location = new System.Drawing.Point(294, 29);
            this.GV_books.Name = "GV_books";
            this.GV_books.ReadOnly = true;
            this.GV_books.Size = new System.Drawing.Size(704, 296);
            this.GV_books.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.cbx_filter_author);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.cb_filter_borrowed);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbx_currency);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbx_to);
            this.panel1.Controls.Add(this.tbx_from);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbx_exclude);
            this.panel1.Location = new System.Drawing.Point(25, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 236);
            this.panel1.TabIndex = 0;
            // 
            // cbx_filter_author
            // 
            this.cbx_filter_author.FormattingEnabled = true;
            this.cbx_filter_author.Location = new System.Drawing.Point(62, 276);
            this.cbx_filter_author.Name = "cbx_filter_author";
            this.cbx_filter_author.Size = new System.Drawing.Size(87, 21);
            this.cbx_filter_author.TabIndex = 11;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(15, 279);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 10;
            this.label21.Text = "Author:";
            // 
            // cb_filter_borrowed
            // 
            this.cb_filter_borrowed.AutoSize = true;
            this.cb_filter_borrowed.Location = new System.Drawing.Point(118, 237);
            this.cb_filter_borrowed.Name = "cb_filter_borrowed";
            this.cb_filter_borrowed.Size = new System.Drawing.Size(15, 14);
            this.cb_filter_borrowed.TabIndex = 9;
            this.cb_filter_borrowed.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Show Borrowed:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "currency:";
            // 
            // cbx_currency
            // 
            this.cbx_currency.FormattingEnabled = true;
            this.cbx_currency.Location = new System.Drawing.Point(85, 197);
            this.cbx_currency.Name = "cbx_currency";
            this.cbx_currency.Size = new System.Drawing.Size(64, 21);
            this.cbx_currency.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "to:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "from:";
            // 
            // tbx_to
            // 
            this.tbx_to.Location = new System.Drawing.Point(118, 159);
            this.tbx_to.Name = "tbx_to";
            this.tbx_to.Size = new System.Drawing.Size(31, 20);
            this.tbx_to.TabIndex = 4;
            // 
            // tbx_from
            // 
            this.tbx_from.Location = new System.Drawing.Point(50, 159);
            this.tbx_from.Name = "tbx_from";
            this.tbx_from.Size = new System.Drawing.Size(31, 20);
            this.tbx_from.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(63, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exclude categories:";
            // 
            // cbx_exclude
            // 
            this.cbx_exclude.FormattingEnabled = true;
            this.cbx_exclude.Location = new System.Drawing.Point(23, 45);
            this.cbx_exclude.Name = "cbx_exclude";
            this.cbx_exclude.Size = new System.Drawing.Size(131, 64);
            this.cbx_exclude.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(30, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1035, 425);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btn_clear_filters);
            this.tabPage1.Controls.Add(this.GV_books);
            this.tabPage1.Controls.Add(this.btn_apply);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1027, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search Books";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(48, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Filter Books";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_clear_filters
            // 
            this.btn_clear_filters.Location = new System.Drawing.Point(127, 302);
            this.btn_clear_filters.Name = "btn_clear_filters";
            this.btn_clear_filters.Size = new System.Drawing.Size(83, 23);
            this.btn_clear_filters.TabIndex = 2;
            this.btn_clear_filters.Text = "Clear filters";
            this.btn_clear_filters.UseVisualStyleBackColor = true;
            this.btn_clear_filters.Click += new System.EventHandler(this.btn_clear_filters_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(22, 302);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(86, 23);
            this.btn_apply.TabIndex = 0;
            this.btn_apply.Text = "Apply filters";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_show_borrowed);
            this.tabPage2.Controls.Add(this.btn_show_history);
            this.tabPage2.Controls.Add(this.cbx_return_books);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.cbx_filter_by_user);
            this.tabPage2.Controls.Add(this.GV_borrowed);
            this.tabPage2.Controls.Add(this.btn_show_all);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btn_filter_by_user);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1027, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Admin Panel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbx_return_books
            // 
            this.cbx_return_books.FormattingEnabled = true;
            this.cbx_return_books.Location = new System.Drawing.Point(498, 214);
            this.cbx_return_books.Name = "cbx_return_books";
            this.cbx_return_books.Size = new System.Drawing.Size(89, 21);
            this.cbx_return_books.TabIndex = 41;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.Location = new System.Drawing.Point(719, 41);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(183, 25);
            this.label22.TabIndex = 38;
            this.label22.Text = "Borrowed Books";
            // 
            // cbx_filter_by_user
            // 
            this.cbx_filter_by_user.FormattingEnabled = true;
            this.cbx_filter_by_user.Location = new System.Drawing.Point(498, 124);
            this.cbx_filter_by_user.Name = "cbx_filter_by_user";
            this.cbx_filter_by_user.Size = new System.Drawing.Size(89, 21);
            this.cbx_filter_by_user.TabIndex = 37;
            // 
            // GV_borrowed
            // 
            this.GV_borrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_borrowed.Location = new System.Drawing.Point(602, 77);
            this.GV_borrowed.Name = "GV_borrowed";
            this.GV_borrowed.ReadOnly = true;
            this.GV_borrowed.Size = new System.Drawing.Size(403, 260);
            this.GV_borrowed.TabIndex = 32;
            // 
            // btn_show_all
            // 
            this.btn_show_all.Location = new System.Drawing.Point(498, 180);
            this.btn_show_all.Name = "btn_show_all";
            this.btn_show_all.Size = new System.Drawing.Size(89, 23);
            this.btn_show_all.TabIndex = 36;
            this.btn_show_all.Text = "Show All";
            this.btn_show_all.UseVisualStyleBackColor = true;
            this.btn_show_all.Click += new System.EventHandler(this.btn_show_all_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_add_title);
            this.groupBox1.Controls.Add(this.tbx_add_author);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbx_edit_category);
            this.groupBox1.Controls.Add(this.btn_add_books);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cbx_edit_book);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.cbx_delete);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbx_edit_pages);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tbx_edit_currency);
            this.groupBox1.Controls.Add(this.tbx_add_price);
            this.groupBox1.Controls.Add(this.tbx_edit_price);
            this.groupBox1.Controls.Add(this.tbx_add_currency);
            this.groupBox1.Controls.Add(this.tbx_edit_author);
            this.groupBox1.Controls.Add(this.tbx_add_pages);
            this.groupBox1.Controls.Add(this.btn_edit);
            this.groupBox1.Controls.Add(this.tbx_add_category);
            this.groupBox1.Controls.Add(this.tbx_edit_name);
            this.groupBox1.Controls.Add(this.btn_add_book);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Location = new System.Drawing.Point(31, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 356);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // tbx_add_title
            // 
            this.tbx_add_title.Location = new System.Drawing.Point(71, 29);
            this.tbx_add_title.Name = "tbx_add_title";
            this.tbx_add_title.Size = new System.Drawing.Size(112, 20);
            this.tbx_add_title.TabIndex = 3;
            // 
            // tbx_add_author
            // 
            this.tbx_add_author.Location = new System.Drawing.Point(71, 55);
            this.tbx_add_author.Name = "tbx_add_author";
            this.tbx_add_author.Size = new System.Drawing.Size(112, 20);
            this.tbx_add_author.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Title:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Author:";
            // 
            // cbx_edit_category
            // 
            this.cbx_edit_category.FormattingEnabled = true;
            this.cbx_edit_category.Location = new System.Drawing.Point(279, 111);
            this.cbx_edit_category.Name = "cbx_edit_category";
            this.cbx_edit_category.Size = new System.Drawing.Size(112, 21);
            this.cbx_edit_category.TabIndex = 33;
            // 
            // btn_add_books
            // 
            this.btn_add_books.Location = new System.Drawing.Point(71, 221);
            this.btn_add_books.Name = "btn_add_books";
            this.btn_add_books.Size = new System.Drawing.Size(112, 23);
            this.btn_add_books.TabIndex = 34;
            this.btn_add_books.Text = "Add Books from file";
            this.btn_add_books.UseVisualStyleBackColor = true;
            this.btn_add_books.Click += new System.EventHandler(this.btn_add_books_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Category:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(228, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Pages:";
            // 
            // cbx_edit_book
            // 
            this.cbx_edit_book.FormattingEnabled = true;
            this.cbx_edit_book.Location = new System.Drawing.Point(279, 29);
            this.cbx_edit_book.Name = "cbx_edit_book";
            this.cbx_edit_book.Size = new System.Drawing.Size(112, 21);
            this.cbx_edit_book.TabIndex = 28;
            this.cbx_edit_book.SelectedIndexChanged += new System.EventHandler(this.cbx_edit_book_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(216, 166);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Currency:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(30, 294);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(30, 13);
            this.label20.TabIndex = 30;
            this.label20.Text = "Title:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(232, 140);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Price:";
            // 
            // cbx_delete
            // 
            this.cbx_delete.FormattingEnabled = true;
            this.cbx_delete.Location = new System.Drawing.Point(71, 291);
            this.cbx_delete.Name = "cbx_delete";
            this.cbx_delete.Size = new System.Drawing.Size(112, 21);
            this.cbx_delete.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(216, 114);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "Category:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Price:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(227, 88);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Author:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(238, 62);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 13);
            this.label19.TabIndex = 22;
            this.label19.Text = "Title:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Currency:";
            // 
            // tbx_edit_pages
            // 
            this.tbx_edit_pages.Location = new System.Drawing.Point(279, 189);
            this.tbx_edit_pages.Name = "tbx_edit_pages";
            this.tbx_edit_pages.Size = new System.Drawing.Size(41, 20);
            this.tbx_edit_pages.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Pages:";
            // 
            // tbx_edit_currency
            // 
            this.tbx_edit_currency.Location = new System.Drawing.Point(279, 163);
            this.tbx_edit_currency.Name = "tbx_edit_currency";
            this.tbx_edit_currency.Size = new System.Drawing.Size(41, 20);
            this.tbx_edit_currency.TabIndex = 19;
            // 
            // tbx_add_price
            // 
            this.tbx_add_price.Location = new System.Drawing.Point(71, 107);
            this.tbx_add_price.Name = "tbx_add_price";
            this.tbx_add_price.Size = new System.Drawing.Size(41, 20);
            this.tbx_add_price.TabIndex = 5;
            // 
            // tbx_edit_price
            // 
            this.tbx_edit_price.Location = new System.Drawing.Point(279, 137);
            this.tbx_edit_price.Name = "tbx_edit_price";
            this.tbx_edit_price.Size = new System.Drawing.Size(41, 20);
            this.tbx_edit_price.TabIndex = 18;
            // 
            // tbx_add_currency
            // 
            this.tbx_add_currency.Location = new System.Drawing.Point(71, 133);
            this.tbx_add_currency.Name = "tbx_add_currency";
            this.tbx_add_currency.Size = new System.Drawing.Size(41, 20);
            this.tbx_add_currency.TabIndex = 6;
            // 
            // tbx_edit_author
            // 
            this.tbx_edit_author.Location = new System.Drawing.Point(279, 85);
            this.tbx_edit_author.Name = "tbx_edit_author";
            this.tbx_edit_author.Size = new System.Drawing.Size(112, 20);
            this.tbx_edit_author.TabIndex = 17;
            // 
            // tbx_add_pages
            // 
            this.tbx_add_pages.Location = new System.Drawing.Point(71, 157);
            this.tbx_add_pages.Name = "tbx_add_pages";
            this.tbx_add_pages.Size = new System.Drawing.Size(41, 20);
            this.tbx_add_pages.TabIndex = 7;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(292, 212);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Edit book";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // tbx_add_category
            // 
            this.tbx_add_category.Location = new System.Drawing.Point(71, 81);
            this.tbx_add_category.Name = "tbx_add_category";
            this.tbx_add_category.Size = new System.Drawing.Size(112, 20);
            this.tbx_add_category.TabIndex = 8;
            // 
            // tbx_edit_name
            // 
            this.tbx_edit_name.Location = new System.Drawing.Point(279, 55);
            this.tbx_edit_name.Name = "tbx_edit_name";
            this.tbx_edit_name.Size = new System.Drawing.Size(112, 20);
            this.tbx_edit_name.TabIndex = 16;
            // 
            // btn_add_book
            // 
            this.btn_add_book.Location = new System.Drawing.Point(93, 183);
            this.btn_add_book.Name = "btn_add_book";
            this.btn_add_book.Size = new System.Drawing.Size(75, 23);
            this.btn_add_book.TabIndex = 0;
            this.btn_add_book.Text = "Add book";
            this.btn_add_book.UseVisualStyleBackColor = true;
            this.btn_add_book.Click += new System.EventHandler(this.btn_add_book_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(83, 318);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete book";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_filter_by_user
            // 
            this.btn_filter_by_user.Location = new System.Drawing.Point(498, 151);
            this.btn_filter_by_user.Name = "btn_filter_by_user";
            this.btn_filter_by_user.Size = new System.Drawing.Size(89, 23);
            this.btn_filter_by_user.TabIndex = 35;
            this.btn_filter_by_user.Text = "Filter by User";
            this.btn_filter_by_user.UseVisualStyleBackColor = true;
            this.btn_filter_by_user.Click += new System.EventHandler(this.btn_filter_by_user_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "|*.json";
            // 
            // btn_show_history
            // 
            this.btn_show_history.Location = new System.Drawing.Point(459, 243);
            this.btn_show_history.Name = "btn_show_history";
            this.btn_show_history.Size = new System.Drawing.Size(128, 35);
            this.btn_show_history.TabIndex = 42;
            this.btn_show_history.Text = "Show my borrowing hisotry";
            this.btn_show_history.UseVisualStyleBackColor = true;
            this.btn_show_history.Click += new System.EventHandler(this.btn_show_history_Click);
            // 
            // btn_show_borrowed
            // 
            this.btn_show_borrowed.Location = new System.Drawing.Point(459, 284);
            this.btn_show_borrowed.Name = "btn_show_borrowed";
            this.btn_show_borrowed.Size = new System.Drawing.Size(128, 35);
            this.btn_show_borrowed.TabIndex = 43;
            this.btn_show_borrowed.Text = "Show currently borrowed books";
            this.btn_show_borrowed.UseVisualStyleBackColor = true;
            this.btn_show_borrowed.Click += new System.EventHandler(this.btn_show_borrowed_Click);
            // 
            // LibraryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "LibraryPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LibraryPanel_FormClosing);
            this.Load += new System.EventHandler(this.LibraryPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_books)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_borrowed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GV_books;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.CheckedListBox cbx_exclude;
        private System.Windows.Forms.Button btn_clear_filters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_currency;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_to;
        private System.Windows.Forms.TextBox tbx_from;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add_book;
        private System.Windows.Forms.CheckBox cb_filter_borrowed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_add_category;
        private System.Windows.Forms.TextBox tbx_add_pages;
        private System.Windows.Forms.TextBox tbx_add_currency;
        private System.Windows.Forms.TextBox tbx_add_price;
        private System.Windows.Forms.TextBox tbx_add_author;
        private System.Windows.Forms.TextBox tbx_add_title;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbx_edit_category;
        private System.Windows.Forms.DataGridView GV_borrowed;
        private System.Windows.Forms.ComboBox cbx_delete;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbx_edit_book;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbx_edit_pages;
        private System.Windows.Forms.TextBox tbx_edit_currency;
        private System.Windows.Forms.TextBox tbx_edit_price;
        private System.Windows.Forms.TextBox tbx_edit_author;
        private System.Windows.Forms.TextBox tbx_edit_name;
        private System.Windows.Forms.Button btn_add_books;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cbx_filter_author;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btn_show_all;
        private System.Windows.Forms.Button btn_filter_by_user;
        private System.Windows.Forms.ComboBox cbx_filter_by_user;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbx_return_books;
        private System.Windows.Forms.Button btn_show_history;
        private System.Windows.Forms.Button btn_show_borrowed;
    }
}

