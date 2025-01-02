using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookCRUD crud = new BookCRUD();
            try
            {
                int a = 1;
                do
                {
                    Console.WriteLine("1.Book List");
                    Console.WriteLine("2.Add Book");
                    Console.WriteLine("3.Modify Book");
                    Console.WriteLine("4.Delete Book");
                    Console.WriteLine("5.Get Book By Id");
                    Console.WriteLine("Select an option from above:");
                    int op = Convert.ToInt32(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            List<Book> books = crud.BookList();
                            Console.WriteLine("Id    Title    Author    Price");
                            foreach (var item in books)
                            {
                                Console.WriteLine(item);
                            }
                            break;

                        case 2:
                            Book b1 = new Book();
                            Console.WriteLine("Enter Id:");
                            b1.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Title:");
                            b1.Title = Console.ReadLine();
                            Console.WriteLine("Enter Author:");
                            b1.Author = Console.ReadLine();
                            Console.WriteLine("Enter Price:");
                            b1.Price = Convert.ToInt32(Console.ReadLine());
                            crud.AddBook(b1);
                            Console.WriteLine("Added the book.");
                            break;

                        case 3:
                            Book b2 = new Book();
                            Console.WriteLine("Enter existing Id:");
                            b2.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter new Title:");
                            b2.Title = Console.ReadLine();
                            Console.WriteLine("Enter new Author:");
                            b2.Author = Console.ReadLine();
                            Console.WriteLine("Enter new Price:");
                            b2.Price = Convert.ToInt32(Console.ReadLine());
                            crud.ModifyBook(b2);
                            Console.WriteLine("Updated the book.");
                            break;

                        case 4:
                            Console.WriteLine("Enter existing Id to delete:");
                            int id = Convert.ToInt32(Console.ReadLine());
                            crud.DeleteBook(id);
                            Console.WriteLine("Deleted the book.");
                            break;

                        case 5:
                            Console.WriteLine("Enter existing Id:");
                            int id2 = Convert.ToInt32(Console.ReadLine());
                            Book book = crud.GetBookById(id2);
                            if (book != null)
                            {
                                Console.WriteLine(book);
                            }
                            else
                            {
                                Console.WriteLine("Book not found.");
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid option. Try again.");
                            break;
                    }

                    Console.WriteLine("Press 1 to continue or 0 to exit:");
                    a = Convert.ToInt32(Console.ReadLine());
                } while (a == 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}