using System.ComponentModel.DataAnnotations;
using AppOrmEntity.Models;

public class CartItem
{
    [Key]
    public int Id { get; set; }
    public int BookId { get; set; }
    public string BookName { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public Book Book { get; set; }
}
