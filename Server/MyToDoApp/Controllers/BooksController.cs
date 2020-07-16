using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyToDoApp.Model;
using MyToDoApp.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyToDoApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IBooksService booksService;
        public BooksController(IBooksService booksService)
        {
            this.booksService = booksService;
        }

        [HttpGet("all")]
        public IEnumerable<Book> Get()
        {
            return booksService.getAllBooks();
        }

        [HttpPost("batchUpdate")]
        public void Post([FromBody] IEnumerable<Book> book)
        {
        }

        [HttpPost("update")]
        public void Post([FromBody] Book books)
        {
        }

        [HttpPost("add")]
        public void add([FromBody] Book book)
        {
        }
    }
}
