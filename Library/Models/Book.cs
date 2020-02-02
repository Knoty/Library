using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookType { get; set; }
        public int? WithClientId { get; set; }

        public virtual Client Client { get; set; }
    }
}
