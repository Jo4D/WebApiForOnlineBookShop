using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Core
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int Ordercode { get; set; }
        public double Amount { get; set; }
        public string Provider { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { set; get; }
        public DateTime ModifiedAt { set; get; }
        public virtual OrderDetail OrderDetail { get; set; }
    }
}
