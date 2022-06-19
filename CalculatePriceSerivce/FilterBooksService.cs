using LibraryManager.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FilterBooks
{
    public class FilterBooksService : IFilterBooksService
    {
        public List<int> FilterByCategories(List<string> categories)
        {
            using (var context = new LibraryContext())
            {
                var categoriesIDs = context.Categories
                                        .Where(x => categories.Contains(x.Name))
                                        .Select(x => x.CategoryID)
                                        .ToList();

                var filteredBooks = context.Books
                                        .Where(x => categoriesIDs.Contains(x.CategoryID))
                                        .Select(x => x.BookID)
                                        .ToList();

                return filteredBooks;
            }
        }

        public List<int> FilterByPrice(double startRange, double endRange, string currency)
        {
            using (var context = new LibraryContext())
            {
                var booksIDs = context.Books
                                    .Where(x => x.Price >= startRange
                                           && x.Price <= endRange
                                           && x.Currency.Equals(currency))
                                    .Select(x => x.BookID)
                                    .ToList();

                return booksIDs;
            }
        }

        public List<int> FilterByState(bool includeBorrowed)
        {
            using (var context = new LibraryContext())
            {
                if (includeBorrowed)
                {
                    var booksIDs = context.Books
                                        .Select(x => x.BookID)
                                        .ToList();

                    return booksIDs;
                }
                else
                {
                    var borrowedBooksIds = context.CurrentlyBorrowed
                                                .Select(x => x.BookID)
                                                .ToList();

                    var booksIDs = context.Books
                                        .Where(x => !borrowedBooksIds.Contains(x.BookID))
                                        .Select(x => x.BookID)
                                        .ToList();

                    return booksIDs;
                }
                
            }
        }

        public List<int> FilterByAuthor(string author)
        {
            using (var context = new LibraryContext())
            {
                var booksIDs = context.Books
                    .Where(x => x.Author.Equals(author))
                    .Select(x => x.BookID)
                    .ToList();

                return booksIDs;
            }
        }
    }
}
