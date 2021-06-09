using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ScheduleChange.Controllers
{
    public class Book
    {
        public string Genre { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }
    }

    public class BookController : Controller
    {
        [Route("/book/{genre}")]
        public IActionResult AddBook(string genre, Book book)
        {
            return Content($"General genre: {genre}, "
                            + $"name: {book.Name}, page count: {book.PageCount}, "
                            + $"book genre: {book.Genre}");
        }
    }
}
