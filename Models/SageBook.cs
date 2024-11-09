using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AppOrmEntity.Models;

namespace AppOrmEntity.Models
{
    public class SageBook
    {
        [Key]
        public int IdSageBook { get; set; }
        public int IdSage { get; set; }
        public int IdBook { get; set; }

        public Sage Sage { get; set; } 
        public Book Book { get; set; }
    }
}
