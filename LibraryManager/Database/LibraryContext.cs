using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LibraryManager.Database
{
    public class LibraryContext: DbContext
    {
        public virtual DbSet<Book> Books { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<BorrowingHistory> BorrowingHistory { get; set; }

        public virtual DbSet<CurrentlyBorrowed> CurrentlyBorrowed { get; set; }
    }
}
