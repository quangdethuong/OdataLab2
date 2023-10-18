using ODataBookStore.Models;
using System.Collections.Generic;

namespace ODataBookStore.Data
{
    public static class DataSource
    {
        private static IList<Book> listBooks { get; set; }
        public static IList<Book> GetBooks()
        {
            if(listBooks != null)
            {
                return listBooks;
            }
            listBooks = new List<Book>();
            Book book = new Book
            {
                Id = 1,
                ISBN="978-0-321-87758-1",
                Title= "QA",
                Author="Qa111",
                Price=59.99m,
                Location = new Address
                {
                    City="CanTho",
                    Street="NVC"
                },
                Press = new Press
                {
                    Id= 1,
                    Name="Kawasaki",
                    Category= Category.Book,
                }
            };
            listBooks.Add(book);
            book = new Book
            {
                Id = 2,
                ISBN = "978-0-321-87758-1",
                Title = "QA2",
                Author = "QA22",
                Price = 50.00m,
                Location = new Address
                {
                    City = "CT",
                    Street = "600, nvc"
                },
                Press = new Press
                {
                    Id = 2,
                    Name = "Honda",
                    Category = Category.Book,
                }
            };
            listBooks.Add(book);
            book = new Book
            {
                Id = 3,
                ISBN = "978-0-321-87758-1",
                Title = "QA3",
                Author = "QA33",
                Price = 30.99m,
                Location = new Address
                {
                    City = "CT",
                    Street = "nvc noi dai"
                },
                Press = new Press
                {
                    Id = 3,
                    Name = "Suzuki",
                    Category = Category.Book,
                }
            };
            listBooks.Add(book);
            return listBooks;
        }
    }
}
