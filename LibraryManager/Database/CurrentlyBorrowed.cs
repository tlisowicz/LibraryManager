using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Database
{
    [Table("CurrentlyBorrowed")]
    public class CurrentlyBorrowed
    {
        [Key, Column(Order = 1)]
        public int BookID { get; set; }

        public virtual Book Book { get; set; }

        [Key, Column(Order = 2)]
        public int UserID { get; set; }

        public virtual User User { get; set; }

        public DateTime DateOfBorrowing { get; set; }
    }
}
