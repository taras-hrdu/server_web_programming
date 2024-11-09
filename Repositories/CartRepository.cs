using System.Linq;
using AppOrmEntity.Context;
using AppOrmEntity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace AppOrmEntity.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CartRepository(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        private ISession Session => _httpContextAccessor.HttpContext.Session;

        public ShoppingCart GetShoppingCartFromSession(string sessionKey)
        {
            var cart = Session.GetObjectFromJson<ShoppingCart>(sessionKey) ?? new ShoppingCart();
            return cart;
        }

        public void SaveShoppingCartToSession(string sessionKey, ShoppingCart cart)
        {
            Session.SetObjectAsJson(sessionKey, cart);
        }

        public void AddToCart(string sessionKey, int bookId)
        {
            var cart = GetShoppingCartFromSession(sessionKey);
            var book = _httpContextAccessor.HttpContext.RequestServices.GetService<AppDbContext>().Books.Find(bookId);
            if (book == null) return;

            var existingItem = cart.Items.FirstOrDefault(item => item.BookId == bookId);
            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                cart.Items.Add(new CartItem
                {
                    BookId = bookId,
                    BookName = book.Name,
                    Price = book.Price,
                    Quantity = 1
                });
            }

            SaveShoppingCartToSession(sessionKey, cart);
        }

        public void RemoveFromCart(string sessionKey, int bookId)
        {
            var cart = GetShoppingCartFromSession(sessionKey);
            var itemToRemove = cart.Items.FirstOrDefault(item => item.BookId == bookId);
            if (itemToRemove != null)
            {
                cart.Items.Remove(itemToRemove);
                SaveShoppingCartToSession(sessionKey, cart);
            }
        }

        public void UpdateQuantity(string sessionKey, int bookId, int quantity)
        {
            var cart = GetShoppingCartFromSession(sessionKey);
            var itemToUpdate = cart.Items.FirstOrDefault(item => item.BookId == bookId);
            if (itemToUpdate != null)
            {
                if (quantity > 0)
                {
                    itemToUpdate.Quantity = quantity;
                    SaveShoppingCartToSession(sessionKey, cart);
                }
                else
                {
                    RemoveFromCart(sessionKey, bookId);
                }
            }
        }
    }
}
