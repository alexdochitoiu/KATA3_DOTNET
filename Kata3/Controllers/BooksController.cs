using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Business.Repositories;
using Data.Models;
using System;
using Kata3.DTOs;

namespace Kata3.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private readonly IBookRepository _repository;

        public BooksController(IBookRepository repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _repository.GetAllBooks();
        }
        
        [HttpGet("{id}")]
        public Book Get(Guid id)
        {
            return _repository.GetBookById(id);
        }
        
        [HttpPost]
        public void Post([FromBody]CreateBookDTO book)
        {
            var entity = Book.Create(book.Title, book.Year, book.Price, book.Genre);
            _repository.CreateBook(entity);
        }
        
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody]UpdateBookDTO book)
        {
            var entity = _repository.GetBookById(id);
            if (entity == null) return NotFound();
            entity.Update(book.Title, book.Year, book.Price, book.Genre);
            return Ok();
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var entity = _repository.GetBookById(id);
            if (entity == null) return NotFound();
            _repository.DeleteBook(id);
            return Ok();
        }
    }
}
