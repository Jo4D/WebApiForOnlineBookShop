using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Core
{
    public class PublishingCompany
    {
        public int PublishingCompanyId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
        public virtual ICollection<Book> Books { get; set; }


    }
}
