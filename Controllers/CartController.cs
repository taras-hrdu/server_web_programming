using Microsoft.AspNetCore.Mvc;
using AppOrmEntity.Models;
using System.Linq;
using AppOrmEntity.Context;
using Microsoft.EntityFrameworkCore;
using AppOrmEntity.Repositories;

namespace AppOrmEntity.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartRepository _cartRepository;
        private readonly AppDbContext _context;

        public CartController(ICartRepository cartRepository, AppDbContext context)
        {
            _cartRepository = cartRepository;
            _context = context;
        }

        public IActionResult Index()
        {
            var cart = _cartRepository.GetShoppingCartFromSession("Cart");

            return View(cart);
        }

        public IActionResult AddToCart(int bookId)
        {
            _cartRepository.AddToCart("Cart", bookId);
            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromCart(int bookId)
        {
            _cartRepository.RemoveFromCart("Cart", bookId);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateQuantity(int bookId, int quantity)
        {
            _cartRepository.UpdateQuantity("Cart", bookId, quantity);
            return RedirectToAction("Index");
        }

        public decimal GetTotalPrice()
        {
            var cart = _cartRepository.GetShoppingCartFromSession("Cart");
            return cart.Items.Sum(item => item.Price * item.Quantity);
        }

        public IActionResult Checkout()
        {
            var cart = _cartRepository.GetShoppingCartFromSession("Cart");

            if (cart.Items.Any())
            {
                var order = new Order
                {
                    OrderDate = DateTime.Now,
                    Items = new List<CartItem>(cart.Items),
                    TotalAmount = GetTotalPrice()
                };

                _context.Orders.Add(order);
                _context.SaveChanges();

                _cartRepository.SaveShoppingCartToSession("Cart", new ShoppingCart());

                return RedirectToAction("OrderConfirmation", new { orderId = order.OrderId });
            }

            return RedirectToAction("Index");
        }


        public IActionResult OrderConfirmation(int orderId)
        {
            var order = _context.Orders
                                .Include(o => o.Items)
                                .FirstOrDefault(o => o.OrderId == orderId);

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }


    }
}
