using Microsoft.AspNetCore.Mvc;
using AppOrmEntity.Models;
using Microsoft.Extensions.Logging;
using AppOrmEntity.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace AppOrmEntity.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var viewModel = new ViewSageBook
            {
                Sages = _context.Sages.ToList(),
                Books = _context.Books.ToList(),
                SageBooks = _context.SageBooks.Include(sb => sb.Sage).Include(sb => sb.Book).ToList()
            };
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}
