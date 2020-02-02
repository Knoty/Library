using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int? TakenBookId { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
