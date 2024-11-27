using System.ComponentModel.DataAnnotations;


namespace EFDemo1.Models
{
    
    public class BookCrud
    {
        private readonly ApplicationDbContext db;
        public BookCrud(ApplicationDbContext db) 
        {
           this.db = db;
        }

        public IEnumerable<Book> GetAllBook()
        {
            ////LINQ
            //var result = from b in db.Books
            //             select b;
            //return result;

            //Lambda
            return db.Books.ToList();
        }

        // Get a single book by its ID
        public Book GetBookById(int id)
        {
            // LINQ
            // var result = (from b in db.Books
            //               where b.BId == id
            //               select b).FirstOrDefault();
            // return result;

            // Lambda
            return db.Books.Where(b => b.BId == id).FirstOrDefault();
        }

        // Add a new book
        public int AddBook(Book bk)
        {
            int result = 0;
            db.Books.Add(bk); // Add book to DbSet
            result = db.SaveChanges(); // Save changes to database
            return result;
        }

        // Update an existing book
        public int UpdateBook(Book bk)
        {
            int result = 0;
            var existingBook = db.Books.Where(b => b.BId == bk.BId).FirstOrDefault();
            if (existingBook != null)
            {
                // Update the properties
                existingBook.Name = bk.Name;
                existingBook.Autor = bk.Autor;
                existingBook.Price = bk.Price;
               

                result = db.SaveChanges(); // Save updated data to database
            }
            return result;
        }

        // Delete a book by its ID
        public int DeleteBook(int id)
        {
            int result = 0;
            var book = db.Books.Where(b => b.BId == id).FirstOrDefault();
            if (book != null)
            {
                db.Books.Remove(book); // Remove book from DbSet
                result = db.SaveChanges(); // Save changes to database
            }
            return result;
        }
    }
}
