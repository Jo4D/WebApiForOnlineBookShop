using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Core
{
    public class Author
    {

        public int AuthorId { get; set; }
        public string Name { get; set; }
        public int PublishingCompanyId { set; get; }
        public virtual PublishingCompany PublishingCompany { set; get; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
