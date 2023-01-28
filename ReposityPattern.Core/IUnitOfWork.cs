using RepositoryPattern.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<Author> Authors { get;}
        IBaseRepository<Book> Books { get; }
        IBaseRepository<CaretItem> CaretItems { get; }
        IBaseRepository<Discount> Discounts { get; }
        IBaseRepository<OrderDetail> OrderDetails { get; }
        IBaseRepository<OrderItem> OrderItems { get; }
        IBaseRepository<Payment> Payments { get; }
        IBaseRepository<PublishingCompany> PublishingCompanies { get; }
        IBaseRepository<ShoppingSession> ShoppingSessions { get; }
        IBaseRepository<Wharehouse> Wharehouses { get; }

        int Complete();

    }
}
