using Microsoft.AspNetCore.Mvc;         // ControllerBase, ApiController, HttpGet
using BookstoreApi.Data;                 // BookstoreContext
using BookstoreApi.Models;               // Book
using Microsoft.EntityFrameworkCore;     // ToListAsync
using System.Collections.Generic;        // IEnumerable
using System.Threading.Tasks;            // Task
namespace BookstoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookstoreContext _context;

        public BooksController(BookstoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            return await _context.Books.ToListAsync();
        }
    }
}
