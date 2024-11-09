using System.Collections.Generic;
using AppOrmEntity.Models;

namespace AppOrmEntity.Repositories
{
    public interface IOrderRepository
    {
        List<Order> GetAllOrders();
        Order GetOrderById(int orderId);
    }
}
