using Microsoft.AspNetCore.Mvc;
using Library.Models;
using Library.Data;

namespace Library.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            var books = MockRepository.GetAll();
            return View(books);
        }

        public IActionResult Details(int id)
        {
            var book = MockRepository.GetById(id);
            if (book == null) return NotFound();

            return View(book);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                MockRepository.Add(book);
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var book = MockRepository.GetById(id);
            if (book == null) return NotFound();

            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                MockRepository.Update(book);
                return RedirectToAction(nameof(Index));
            }

            return View(book);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var book = MockRepository.GetById(id);
            if (book == null) return NotFound();

            return View(book);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            MockRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}