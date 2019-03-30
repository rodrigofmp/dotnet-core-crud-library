using LibraryAPI.Core.Entities;
using LibraryAPI.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Persistence
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryContext context;

        public BookRepository(LibraryContext context)
        {
            this.context = context;
        }

        public void Add(Book book)
        {
            context.Books.Add(book);
        }

        public List<Book> GetAllBooks()
        {
            return context.Books.OrderBy(b => b.Title).ToList();
        }

        public Book GetBook(int id)
        {
            return context.Books.Find(id);
        }

        public void Remove(Book book)
        {
            context.Remove(book);
        }
    }
}
