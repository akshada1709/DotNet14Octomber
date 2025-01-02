using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionCrud
{
    public class BookCRUD
    {
        List<Book> Books;

        public BookCRUD()
        {
            Books = new List<Book>(); // Initialize an empty list of books
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void ModifyBook(Book book) // Contains new values
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Id == book.Id)
                {
                    Books[i].Title = book.Title;
                    Books[i].Author = book.Author;
                    Books[i].Price = book.Price;
                    break;
                }
            }
        }

        public void DeleteBook(int id)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Id == id)
                {
                    Books.RemoveAt(i);
                    break;
                }
            }
        }

        public List<Book> BookList()
        {
            return Books;
        }

        public Book GetBookById(int id)
        {
            foreach (var item in Books)
            {
                if (item.Id == id)
                {
                    return item; // Found the book
                }
            }
            return null; // Book not found
        }
    }
}
