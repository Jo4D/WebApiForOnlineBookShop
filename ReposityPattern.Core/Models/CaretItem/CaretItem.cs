using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Core
{
    public class CaretItem
    {
        public int CaretItemId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int Quantity { get; set; }
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        public int ShoppingSessionId { get; set; }
        public virtual ShoppingSession ShoppingSession { get; set; }
    }
}
