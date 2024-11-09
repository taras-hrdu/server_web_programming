using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppOrmEntity.Models
{
    public class Book
    {
        [Key]
        public int IdBook { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
