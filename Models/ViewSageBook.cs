using System;
namespace AppOrmEntity.Models
{
	public class ViewSageBook
	{
        public IEnumerable<Sage> Sages { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<SageBook> SageBooks { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
