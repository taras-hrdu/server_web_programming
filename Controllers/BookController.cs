using System;
using AppOrmEntity.Context;
using AppOrmEntity.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;
using System.Linq;
using Microsoft.AspNetCore.Http;
using AppOrmEntity.Repositories;

namespace AppOrmEntity.Controllers
{
	public class BookController: Controller
	{
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var currentBook = _bookRepository.GetBookById(id);

            return View(currentBook);
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookRepository.AddBook(book);
                return RedirectToAction("Index", "Admin");
            }
            return View(book);
        }

        [HttpPost]
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                _bookRepository.DeleteBook(id.Value);
            }
            return RedirectToAction("Index", "Admin");
        }

        [HttpPost]
        public IActionResult Update(int id, Book book)
        {
            var currentBook = _bookRepository.GetBookById(id);

            currentBook.Name = book.Name;
            currentBook.Description = book.Description;
            currentBook.Price = book.Price;

            _bookRepository.UpdateBook(currentBook);

            return RedirectToAction("Index", "Admin");
        }
    }
}
