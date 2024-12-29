using Microsoft.EntityFrameworkCore;

namespace OnlineBookStore.Models
{
    public class OnlineBookStoreContext:DbContext
    {
        public OnlineBookStoreContext(DbContextOptions<OnlineBookStoreContext> options)
        : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
