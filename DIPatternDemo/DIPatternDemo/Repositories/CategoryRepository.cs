using DIPatternDemo.Data;
using DIPatternDemo.Models;

namespace DIPatternDemo.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext db;

        public CategoryRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddCategory(Category category)
        {
            int result = 0;
            db.Categories?.Add(category);
            result = db.SaveChanges();
            return result;
        }

        public int DeleteCategory(int id)
        {
            int result = 0;
            var cat = db.Categories?.Where(x => x.CategoryId == id).SingleOrDefault();
            if (cat != null)
            {
                db.Categories?.Remove(cat);
                result = db.SaveChanges();
            }
            return result;
        }

        public IEnumerable<Category> GetCategories()
        {
            return db.Categories?.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return db.Categories?.Where(x => x.CategoryId == id).SingleOrDefault();
        }

        public int UpdateCategory(Category category)
        {
            int result = 0;

            var e = db.Categories?.Where(x => x.CategoryId == category.CategoryId).SingleOrDefault();
            if (e != null)
            {

                e.CategoryId = category.CategoryId;
                e.CategoryName = category.CategoryName;
               

                result = db.SaveChanges();
            }
            return result;
        }
    }
}
