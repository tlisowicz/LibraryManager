using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LibraryManager.Database;
using Newtonsoft.Json;
namespace CRUDBooksLibrary
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę klasy „Service1” w kodzie i pliku konfiguracji.
    public class CRUDService : ICRUDService
    {
        private struct ParsedBook
        {
            public string author;
            public string title;
            public string category;
            public double price;
            public string currency;
            public int pages;
        }
        public bool AddBook(string author, string title, double price, string currency, int pages, string category)
        {
            try
            {
                using (var context = new LibraryContext())
                {
                    var booksNames = context.Books
                        .Select(x => x.Title)
                        .ToList();

                    if (booksNames.Contains(title)) 
                    {
                        return false;
                    }

                    var categoriesNames = context.Categories
                        .Select(x => x.Name)
                        .ToList();

                    if (!categoriesNames.Contains(category)) 
                    {
                        Category cat = new Category()
                        {
                            Name = category
                        };

                        context.Categories.Add(cat);
                        context.SaveChanges();
                    }
                    var categoryId = context.Categories
                        .Where(x => x.Name.Equals(category))
                        .Select(x => x.CategoryID)
                        .ToArray()[0];
                    
                    var book = new Book()
                    {
                        Author = author,
                        Title = title,
                        Price = price,
                        Currency = currency,
                        Pages = pages,
                        CategoryID = categoryId,
                    };

                    context.Books.Add(book);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public bool AddBooksFormJson(string filePath)
        {
            try
            {
                using (StreamReader r = new StreamReader(filePath))
                {
                    string content = r.ReadToEnd();
                    List<ParsedBook> books = JsonConvert.DeserializeObject<List<ParsedBook>>(content);

                    foreach (var book in books)
                    {
                        bool isAdded = AddBook(book.author, book.title, book.price, book.currency, book.pages, book.category);
                        if (!isAdded)
                        {
                            return false;
                        }
                    }
                    return true;
                }               
            }
            catch (IOException)
            {
                return false;
            }
        }

        public bool DeleteBook(string title)
        {
            try
            {
                using (var context = new LibraryContext())
                {
                    var book = context.Books
                        .Where(x => x.Title.Equals(title))
                        .Select(x => x)
                        .ToArray()[0];

                    context.Entry(book).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateBook(string title, string newTitle=null, string author=null, double price=0.0, string currency=null, int pages=0, string category=null)
        {
            try
            {
                using (var context = new LibraryContext())
                {
                    var book = context.Books
                        .Where(x => x.Title.Equals(title))
                        .Select(x => x)
                        .ToArray()[0];

                    var categoryId = context.Categories
                        .Where(x => x.Name.Equals(category))
                        .Select(x => x.CategoryID)
                        .ToArray()[0];

                    book.Author = author is null ? book.Author : author;
                    book.Title = newTitle is null ? book.Title : newTitle;
                    book.Price = price == 0.0 ? book.Price : price;
                    book.Currency = currency is null ? book.Currency : currency;
                    book.Pages = pages == 0 ? book.Pages : pages;
                    book.CategoryID = category is null ? book.CategoryID : categoryId;

                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AddBookToBorrowed(string user, string book)
        {
            try
            {
                using (var context = new LibraryContext())
                {
                    int userID = context.Users
                        .Where(x => x.Name.Equals(user))
                        .Select(x => x.UserID)
                        .ToList()[0];

                    int bookID = context.Books
                        .Where(x => x.Title.Equals(book))
                        .Select(x => x.BookID)
                        .ToList()[0];

                    var entity = new CurrentlyBorrowed()
                    {
                        UserID = userID,
                        BookID = bookID,
                        DateOfBorrowing = DateTime.Now
                    };
                    context.CurrentlyBorrowed.Add(entity);
                    context.SaveChanges();
                    return true;
                }
            } 
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteBookFromBorrowed(string user, string book)
        {
            try
            {
                using (var context = new LibraryContext())
                {
                    int userID = context.Users
                        .Where(x => x.Name.Equals(user))
                        .Select(x => x.UserID)
                        .ToList()[0];

                    int bookID = context.Books
                        .Where(x => x.Title.Equals(book))
                        .Select(x => x.BookID)
                        .ToList()[0];

                    var entity = context.CurrentlyBorrowed
                        .Where(x => x.UserID == userID && x.BookID == bookID)
                        .Select(x => x)
                        .ToList()[0];

                    var bookToHistory = new BorrowingHistory()
                    {
                        BookID = entity.BookID,
                        UserID = entity.UserID,
                        DateOfBorrowing = entity.DateOfBorrowing,
                        DateOfReturn = DateTime.Now
                    };
                    context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
                    context.BorrowingHistory.Add(bookToHistory);

                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

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
    }
 
}
