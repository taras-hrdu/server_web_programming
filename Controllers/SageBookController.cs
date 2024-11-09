using AppOrmEntity.Context;
using AppOrmEntity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppOrmEntity.Repositories;

public class SageBookController : Controller
{
    private readonly ISageBookRepository _sageBookRepository;
    private readonly ISageRepository _sageRepository;
    private readonly IBookRepository _bookRepository;

    public SageBookController(ISageBookRepository sageBookRepository, ISageRepository sageRepository, IBookRepository bookRepository)
    {
        _sageBookRepository = sageBookRepository;
        _sageRepository = sageRepository;
        _bookRepository = bookRepository;
    }

    public IActionResult Create()
    {
        ViewBag.Sages = new SelectList(_sageRepository.GetAllSages(), "IdSage", "Name");
        ViewBag.Books = new SelectList(_bookRepository.GetAllBooks(), "IdBook", "Name");
        return View();
    }

    [HttpPost]
    public IActionResult Create(int IdSage, int IdBook)
    {
        if (ModelState.IsValid)
        {
            if (_sageBookRepository.ExistsSageBook(IdSage, IdBook))
            {
                return RedirectToAction("Create", "SageBook");
            }

            var sage = _sageRepository.GetSageById(IdSage);
            var book = _bookRepository.GetBookById(IdBook);
            var sageBook = new SageBook { IdSage = IdSage, IdBook = IdBook, Book = book, Sage = sage };

            _sageBookRepository.AddSageBook(sageBook);
            return RedirectToAction("Index", "Admin");
        }

        ViewBag.Sages = new SelectList(_sageRepository.GetAllSages(), "IdSage", "Name", IdSage);
        ViewBag.Books = new SelectList(_bookRepository.GetAllBooks(), "IdBook", "Name", IdBook);
        return View();
    }

    [HttpPost]
    public IActionResult Delete(int? id)
    {
        if (id != null)
        {
            _sageBookRepository.DeleteSageBook(id.Value);
        }
        return RedirectToAction("Index", "Admin");
    }
}
