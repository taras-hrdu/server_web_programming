using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppOrmEntity.Models
{
    public class Sage
    {
        [Key]
        public int IdSage { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Photo { get; set; }
        public string City { get; set; }
    }
}
