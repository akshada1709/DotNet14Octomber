using DIPatternDemo1.Data;
using DIPatternDemo1.Models;

namespace DIPatternDemo1.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext db;

        public ProductRepository(ApplicationDbContext db) 
        {
            this.db = db;
        }
        public int AddProduct(Product prod)
        {
            int result = 0;
            db.Products.Add(prod);
            db.SaveChanges();
            return result;
        }

        public int DeleteProduct(int id)
        {
            int result = 0;
            var emp = db.Products?.Where(x => x.ProductId == id).SingleOrDefault();
            if (emp != null)
            {
                db.Products?.Remove(emp);
                result = db.SaveChanges();

            }
            return result;
        }

        public Product GetProductById(int id)
        {
            return db.Products.Where(x => x.ProductId == id).SingleOrDefault();
        }

        public IEnumerable<Product> GetProducts()
        {
            var result = (from p in db.Products
                          join c in db.Categories on p.CategoryId equals c.CategoryId
                          select new Product
                          {
                              ProductId = p.ProductId,
                              ProductName = p.ProductName,
                              Price = p.Price,
                              CategoryId = p.CategoryId,
                              ImageUrl = p.ImageUrl,
                          }).ToList();
            return result;
        }

        public int UpdateProduct(Product prod)
        {
            int result = 0;
            var p=db.Products.Where(x=>x.ProductId==prod.ProductId).SingleOrDefault();
            if (p != null) 
            {
                //db.Entry(prod).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
                p.ProductName = prod.ProductName;
                p.Price= prod.Price;
                p.CategoryId = prod.CategoryId;
                p.ImageUrl = prod.ImageUrl;
                result=db.SaveChanges();
            }
            throw new NotImplementedException();
        }
    }
}
