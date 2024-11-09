using System.Collections.Generic;
using System.Linq;
using AppOrmEntity.Models;
using AppOrmEntity.Context;

namespace AppOrmEntity.Repositories
{
    public class SageBookRepository : ISageBookRepository
    {
        private readonly AppDbContext _context;

        public SageBookRepository(AppDbContext context)
        {
            _context = context;
        }

        public SageBook GetSageBookById(int id)
        {
            return _context.SageBooks.FirstOrDefault(sb => sb.IdSageBook == id);
        }

        public IEnumerable<SageBook> GetAllSageBooks()
        {
            return _context.SageBooks.ToList();
        }

        public void AddSageBook(SageBook sageBook)
        {
            _context.SageBooks.Add(sageBook);
            _context.SaveChanges();
        }

        public void DeleteSageBook(int id)
        {
            var sageBook = _context.SageBooks.FirstOrDefault(sb => sb.IdSageBook == id);
            if (sageBook != null)
            {
                _context.SageBooks.Remove(sageBook);
                _context.SaveChanges();
            }
        }

        public bool ExistsSageBook(int idSage, int idBook)
        {
            return _context.SageBooks.Any(sb => sb.IdSage == idSage && sb.IdBook == idBook);
        }
    }
}
