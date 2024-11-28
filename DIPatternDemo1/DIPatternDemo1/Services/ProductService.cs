using DIPatternDemo1.Models;
using DIPatternDemo1.Repositories;

namespace DIPatternDemo1.Services
{
    public class ProductService : IProductService
    {
        private readonly ProductRepository repo;

        public ProductService(ProductRepository repo)
        {
            this.repo = repo;
        }

        public int AddProduct(Product prod)
        {
            return repo.AddProduct(prod);
        }

        public int DeleteProduct(int id)
        {
           return repo.DeleteProduct(id);
        }

        public Product GetProductById(int id)
        {
            return repo.GetProductById(id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return repo.GetProducts();
        }

        public int UpdateProduct(Product prod)
        {
            return repo.UpdateProduct(prod);
        }
    }
}
