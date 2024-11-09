using System.Collections.Generic;
using System.Linq;
using AppOrmEntity.Models;
using AppOrmEntity.Context;

namespace AppOrmEntity.Repositories
{
    public class SageRepository : ISageRepository
    {
        private readonly AppDbContext _context;

        public SageRepository(AppDbContext context)
        {
            _context = context;
        }

        public Sage GetSageById(int id)
        {
            return _context.Sages.FirstOrDefault(s => s.IdSage == id);
        }

        public IEnumerable<Sage> GetAllSages()
        {
            return _context.Sages.ToList();
        }

        public void AddSage(Sage sage)
        {
            _context.Sages.Add(sage);
            _context.SaveChanges();
        }

        public void UpdateSage(Sage sage)
        {
            _context.Sages.Update(sage);
            _context.SaveChanges();
        }

        public void DeleteSage(int id)
        {
            var sage = _context.Sages.FirstOrDefault(s => s.IdSage == id);
            if (sage != null)
            {
                _context.Sages.Remove(sage);
                _context.SaveChanges();
            }
        }
    }
}
