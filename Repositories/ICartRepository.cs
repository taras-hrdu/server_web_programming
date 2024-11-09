using System.Collections.Generic;
using AppOrmEntity.Models;

namespace AppOrmEntity.Repositories
{
    public interface ICartRepository
    {
        ShoppingCart GetShoppingCartFromSession(string sessionKey);
        void SaveShoppingCartToSession(string sessionKey, ShoppingCart cart);
        void AddToCart(string sessionKey, int bookId);
        void RemoveFromCart(string sessionKey, int bookId);
        void UpdateQuantity(string sessionKey, int bookId, int quantity);
    }
}
