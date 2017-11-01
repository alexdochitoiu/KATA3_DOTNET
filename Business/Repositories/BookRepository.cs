using System;
using System.Collections.Generic;
using Data.Models;
using Data.Context;
using System.Linq;

namespace Business.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly IDatabaseContext _dbContext;

        public BookRepository(IDatabaseContext databaseContext)
        {
            _dbContext = databaseContext;
        }

        public void CreateBook(Book book)
        {
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
        }

        public void DeleteBook(Guid id)
        {
            var book = GetBookById(id);
            _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();
        }

        public void EditBook(Book book)
        {
            _dbContext.Books.Update(book);
            _dbContext.SaveChanges();
        }

        public IReadOnlyList<Book> GetAllBooks()
        {
            return _dbContext.Books.ToList();
        }

        public Book GetBookById(Guid id)
        {
            return _dbContext.Books.FirstOrDefault(b => b.Id == id);
        }
    }
}
