using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppOrmEntity.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<CartItem> Items { get; set; } = new List<CartItem>();
        public decimal TotalAmount { get; set; }
    }
}
