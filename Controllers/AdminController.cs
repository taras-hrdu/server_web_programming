using Microsoft.AspNetCore.Mvc;
using AppOrmEntity.Models;
using Microsoft.Extensions.Logging;
using AppOrmEntity.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using AppOrmEntity.Repositories;
using System;

namespace AppOrmEntity.Controllers
{
    [Authorize(Policy = "AdminOnly")]
    public class AdminController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly AppDbContext _context;

        public AdminController(IOrderRepository orderRepository, AppDbContext context)
        {
            _orderRepository = orderRepository;
            _context = context;
        }

        public IActionResult Index()
        {
            var viewModel = new ViewSageBook
            {
                Sages = _context.Sages.ToList(),
                Books = _context.Books.ToList(),
                SageBooks = _context.SageBooks.Include(sb => sb.Sage).Include(sb => sb.Book).ToList(),
                Orders = _orderRepository.GetAllOrders()
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

        public IActionResult OrderIndex()
        {
            var orders = _orderRepository.GetAllOrders();
            return View(orders);
        }

        public IActionResult Details(int id)
        {
            var order = _orderRepository.GetOrderById(id);

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

    }
}
