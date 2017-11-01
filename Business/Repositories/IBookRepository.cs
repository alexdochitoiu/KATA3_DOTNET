using Data.Models;
using System;
using System.Collections.Generic;

namespace Business.Repositories
{
    public interface IBookRepository
    {
        Book GetBookById(Guid id);
        IReadOnlyList<Book> GetAllBooks();
        void CreateBook(Book book);
        void EditBook(Book book);
        void DeleteBook(Guid id);
    }
}
