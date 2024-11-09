using System.Collections.Generic;
using AppOrmEntity.Models;

namespace AppOrmEntity.Repositories
{
    public interface ISageBookRepository
    {
        SageBook GetSageBookById(int id);                   
        IEnumerable<SageBook> GetAllSageBooks();             
        void AddSageBook(SageBook sageBook);                
        void DeleteSageBook(int id);                         
        bool ExistsSageBook(int idSage, int idBook);         
    }
}
