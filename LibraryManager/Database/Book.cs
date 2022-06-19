using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Database
{
    public class Book
    {
        public int BookID { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public double Price { get; set; }

        public string Currency { get; set; }

        public int Pages { get; set; }

        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<BorrowingHistory> BorrowedBy { get; set; }
    }
}
