using Books.API.Data;
using Books.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.API.Controllers
{
    [ApiController]
    [Route("api/Books")]
    public class BookController:ControllerBase
    {
        #region [Fields]
        public readonly LibraryContext context ;

        #endregion

        #region [Ctor]

        public BookController(LibraryContext _context)
        {
            context = _context;
        }

        #endregion

        #region [APIS]

        [HttpGet]
        public IActionResult GetAll()
        {
            return  Ok(context.Books);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetBook(int id)
        {
            var book = context.Books.Find(id);
            return Ok(book);
        }
        [HttpPost]
        public IActionResult Post(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
            return Ok(book);
        }
        [HttpDelete("remove/{id:int}")]
        public IActionResult Remove(int id)
        {
            var book = context.Books.Find(id);
            context.Books.Remove(book);
            context.SaveChanges();
            return Ok();
        }
        [HttpPost("update")]
        public IActionResult Update(Book book)
        {
            context.Books.Update(book);
            context.SaveChanges();
            return Ok(book);
        }
        #endregion

    }
}
