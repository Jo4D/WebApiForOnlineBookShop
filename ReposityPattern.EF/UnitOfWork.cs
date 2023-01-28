using RepositoryPattern.Core;
using RepositoryPattern.Core.Repositories;
using RepositoryPattern.EF.Repositories;

namespace RepositoryPattern.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;
        

        public IBaseRepository<Author> Authors {get; private set;}

        public IBaseRepository<Book> Books {get; private set;}

        public IBaseRepository<CaretItem> CaretItems {get; private set;}

        public IBaseRepository<Discount> Discounts {get; private set;}

        public IBaseRepository<OrderDetail> OrderDetails {get; private set;}

        public IBaseRepository<OrderItem> OrderItems {get; private set;}

        public IBaseRepository<Payment> Payments {get; private set;}

        public IBaseRepository<PublishingCompany> PublishingCompanies {get; private set;}

        public IBaseRepository<ShoppingSession> ShoppingSessions {get; private set;}

        public IBaseRepository<Wharehouse> Wharehouses {get; private set;}
        public UnitOfWork(ApplicationDbContext _context)
        {
            context = _context;
            Authors = new BaseRepository<Author>(context);
            Books = new BaseRepository<Book>(context);
            CaretItems = new BaseRepository<CaretItem>(context);
            Discounts = new BaseRepository<Discount>(context);
            OrderDetails = new BaseRepository<OrderDetail>(context);
            OrderItems = new BaseRepository<OrderItem>(context);
            Payments = new BaseRepository<Payment>(context);
            PublishingCompanies = new BaseRepository<PublishingCompany>(context);
            ShoppingSessions = new BaseRepository<ShoppingSession>(context);
            Wharehouses = new BaseRepository<Wharehouse>(context);


        }
        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
