using System;
using System.Collections.Generic;
using AppOrmEntity.Models;

namespace AppOrmEntity.Repositories
{
    public interface ISageRepository
    {
        Sage GetSageById(int id);                 
        IEnumerable<Sage> GetAllSages();           
        void AddSage(Sage sage);                  
        void UpdateSage(Sage sage);               
        void DeleteSage(int id);                  
    }
}
