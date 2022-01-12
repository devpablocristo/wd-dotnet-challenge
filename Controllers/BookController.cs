using BookStore;
using BookStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        /// <summary>
        /// Adds a list of books
        /// </summary>
        /// <param name="bookList"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<string> AddBooks( [FromBodyAttribute] List<Book> bookList ) {

        }
        
        /// <summary>
        /// Returns all the existing books
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Book> ListBooks() {
            
            return Program.BookStorage;
        }
    }
}
