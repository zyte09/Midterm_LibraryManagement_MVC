using LibraryManagement_MVC.BusLogic.Model;
using LibraryManagement_MVC.BusLogic.Service;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement_MVC.Controllers
{
    public class BookController : Controller
    {
        private readonly BookService _bookservice = new BookService();
        public IActionResult Index()
        {
            var books = _bookservice.GetAll();
            return View(books);
        }

        public IActionResult AddNewBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(tblBook book)
        {
            try
            {
                bool result = _bookservice.Add(book);
                return Json(new { success = result, message = result ? "Book Added Sucessfully" : "Failed to Add Book" });
            }

            catch (Exception ex)
            {
                return Json(new {sucess = false, message = ex.Message });
            }
        }

        public IActionResult EditBook(int id)
        {
            var book = _bookservice.GetBookById(id);
            return View(book);
        }

        [HttpPost]
        public IActionResult EditBook(tblBook book)
        {
            try
            {
                bool result = _bookservice.Update(book);
                return Json(new { sucess = result, message = result ? "Book Updated Sucessfully" : "Failed to Update Book" });
            }
            catch (Exception ex)
            {
                return Json(new { sucess = false, message = ex.Message });
            }
        }
    }
}
