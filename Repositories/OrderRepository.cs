using System.Collections.Generic;
using System.Linq;
using AppOrmEntity.Context;
using AppOrmEntity.Models;
using Microsoft.EntityFrameworkCore;

namespace AppOrmEntity.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context;

        public OrderRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Order> GetAllOrders()
        {
            return _context.Orders.Include(o => o.Items).ToList();
        }

        public Order GetOrderById(int orderId)
        {
            return _context.Orders
                           .Where(o => o.OrderId == orderId)
                           .Include(o => o.Items)
                           .FirstOrDefault();
        }
    }
}
