using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Database
{
    class DatabaseHandler
    {
        public string GenerateSHA256Hash(string input)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(input);
            System.Security.Cryptography.SHA256Managed sha256string = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = sha256string.ComputeHash(bytes);

            StringBuilder hex = new StringBuilder(hash.Length * 2);
            foreach (byte b in hash)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }

        public List<string> GetUsers()
        {
            using (var context = new LibraryContext())
            {
                var names = context.Users
                    .Select(x => x.Name)
                    .ToList();
                return names;
            }
        }

        public string FetchPassword(string UserName)
        {
            using (var context = new LibraryContext())
            {
                var password = context.Users
                    .Where(x => x.Name.Equals(UserName))
                    .Select(x => x.Password)
                    .ToList()[0];

                return password;
            }
        }

        public bool AddUser(string name, string password)
        {
            try
            {
                var encryptedPassword = GenerateSHA256Hash(password);
                using (var context = new LibraryContext())
                {
                    var user = new User()
                    {
                        Name = name,
                        Password = encryptedPassword,
                        role = User.Role.USER,
                    };

                    context.Users.Add(user);
                    context.SaveChanges();
                    return true;
                }
            } 
            
            catch (Exception)
            {
                return false;
            }
        }

        public int GetUserRole(string name)
        {
            using (var context = new LibraryContext())
            {
                var role = context.Users
                    .Where(x => x.Name.Equals(name))
                    .Select(x => x.role)
                    .ToArray()[0];

                return (int)role;
            }
        }

        public string[] GetHeaders()
        {
            var names = typeof(Book).GetProperties()
                .Select(x => x.Name)
                .ToList();

            names.Remove("Category");
            names.Remove("BorrowedBy");
            names.Add("Borrowed");

            return names.ToArray();
        }


        public List<List<string>> GetBooks(List<int> filteredBooksIds = null)
        {
            using (var context = new LibraryContext())
            {
                List<Book> books;
                if (!(filteredBooksIds is null))
                {
                    books = context.Books
                        .Where(x => filteredBooksIds.Contains(x.BookID))
                        .Select(x => x)
                        .ToList();
                }
                else
                {
                    books = context.Books
                        .Select(x => x)
                        .ToList();
                }

                books.Select(x => new
                    {
                        x.BookID,
                        x.Title,
                        x.Author,
                        x.Price,
                        x.Currency,
                        x.Pages,
                        x.CategoryID
                    });

                List<List<string>> Querry = new List<List<string>>();
                List<string> categories = new List<string>();

                foreach (var book in books)
                {
                    List<string> row = new List<string>();
                    var category = context.Categories
                        .Where(x => x.CategoryID == book.CategoryID)
                        .Select(x => x.Name)
                        .ToList()[0];

                    bool isBorrowed = context.CurrentlyBorrowed
                                           .Select(x => x.BookID)
                                           .ToList()
                                           .Contains(book.BookID);

                    row.Add(book.BookID.ToString());
                    row.Add(book.Title);
                    row.Add(book.Author);
                    row.Add(book.Price.ToString(format: "N2"));
                    row.Add(book.Currency.ToString());
                    row.Add(book.Pages.ToString());
                    row.Add(category);
                    row.Add(isBorrowed == true ? "Yes" : "No");
                    Querry.Add(row);
                }
                return Querry;
            }
        }

        public List<string> GetCurrencies()
        {
            using(var context = new LibraryContext())
            {
                var currencies = context.Books
                    .Select(x => x.Currency)
                    .Distinct()
                    .ToList();

                return currencies;
            }
        }
        public List<string> GetCategories()
        {
            using (var context = new LibraryContext())
            {
                var categoriesNames = context.Categories
                    .Select(x => x.Name)
                    .ToList();

                return categoriesNames;
            }
        }

        public List<int> GetAllBooksIds()
        {
            using (var context = new LibraryContext())
            {
                var Ids = context.Books
                    .Select(x => x.BookID)
                    .ToList();

                return Ids;
            }
        }

        public List<int> GetUnborrowedBooksIds()
        {
            using (var context = new LibraryContext())
            {
                var borrowedBooksIds = context.CurrentlyBorrowed
                    .Select(x => x.BookID)
                    .ToList();

                var Ids = context.Books
                    .Where(x => !borrowedBooksIds.Contains(x.BookID))
                    .Select(x => x.BookID)
                    .ToList();

                return Ids;
            }
        }

        public List<string> GetBooksTitles()
        {
            using (var context = new LibraryContext())
            {
                var titles = context.Books
                    .Select(x => x.Title)
                    .ToList();

                return titles;
            }
        }

        public List<string> GetBookInfo(string title) 
        {
            using (var context = new LibraryContext())
            {
                var book = context.Books
                    .Where(x => x.Title.Equals(title))
                    .Select(x => x)
                    .ToList()[0];

                var categoryName = context.Categories
                    .Where(x => x.CategoryID == book.CategoryID)
                    .Select(x => x.Name)
                    .ToArray()[0];

                var result = new List<string>();
                result.Add(book.Title);
                result.Add(book.Author);
                result.Add(categoryName);
                result.Add(book.Price.ToString(format: "N2"));
                result.Add(book.Currency.ToString());
                result.Add(book.Pages.ToString());

                return result;
            }
        }

        public List<string> GetAuthors()
        {
            using (var context = new LibraryContext())
            {
                var authors = context.Books
                    .Select(x => x.Author)
                    .Distinct()
                    .ToList();

                return authors;
            }
        }

        public List<List<string>> GetBorrowedBooks(string user = null)
        {
            using (var context = new LibraryContext())
            {
                List<List<string>> Query = new List<List<string>>();

                List<int> usersIds = new List<int>();
                if (user is null)
                {
                    usersIds = context.CurrentlyBorrowed
                        .Select(x => x.UserID)
                        .Distinct()
                        .ToList();
                }

                else
                {
                    usersIds = context.Users
                        .Where(x => x.Name.Equals(user))
                        .Select(x => x.UserID)
                        .ToList();
                }

                if (usersIds.Count != 0)
                {
                    foreach (var u in usersIds)
                    {

                        var booksIds = context.CurrentlyBorrowed
                            .Where(x => x.UserID == u)
                                .Select(x => x.BookID)
                                .ToList();

                        var dates = context.CurrentlyBorrowed
                            .Where(x => x.UserID == u)
                                .Select(x => x.DateOfBorrowing)
                                .ToList();

                        var booksTitles = context.Books
                            .Where(x => booksIds.Contains(x.BookID))
                            .Select(x => x.Title)
                            .ToList();

                        foreach (var book in booksTitles.Select((title, index) => new { index, title}))
                        {
                            List<string> row = new List<string>();
                            row.Add(book.title);
                            row.Add(dates[book.index].ToString());

                            Query.Add(row);
                        }
                    }
                }
                return Query;
            }
            
        }
    }

    
}
