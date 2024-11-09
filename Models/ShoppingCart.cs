using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppOrmEntity.Models
{
    public class ShoppingCart
    {
        [Key]
        public int Id { get; set; }
        public List<CartItem> Items { get; set; } = new List<CartItem>();
        public decimal TotalPrice { get; set; }
    }
}
