using RESTDemo.Data;
using RESTDemo.Models;
using System.Collections.Generic;
using System.Linq;

namespace RESTDemo.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext db;
        public BookRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddBook(Book book)
        {
            int result;
            db.Books?.Add(book);
            result = db.SaveChanges();
            return result;
        }

        public int DeleteBook(int id)
        {
            int result = 0;
            var b = db.Books?.Where(x => x.BId == id).FirstOrDefault();
            if (b != null)
            {
                db.Books?.Remove(b);
                result = db.SaveChanges();
            }
            return result;
        }

        public IEnumerable<Book> GetBookByAuthor(string name)
        {
            var model = db.Books?.Where(x => x.Author.Contains(name)).ToList();
            return model;

        }

        public Book GetBookById(int id)
        {
            return db.Books?.Where(x => x.BId == id).FirstOrDefault();
        }

        public IEnumerable<Book> GetBooks()
        {
            return db.Books.ToList();
        }

        public int UpdateBook(Book book)
        {
            int result = 0;
            var b = db.Books?.Where(x => x.BId == book.BId).FirstOrDefault();
            if (b != null)
            {
                db.Entry<Book>(b).CurrentValues.SetValues(book);
                result = db.SaveChanges();
            }
            return result;
        }

    }
}


