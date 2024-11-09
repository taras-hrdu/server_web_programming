using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppOrmEntity.Models;

namespace AppOrmEntity.Repositories
{
    public interface IAccountRepository
    {
        Task<User> GetUserByUsernameAndPasswordAsync(string username, string password);
        Task<User> GetUserByUsernameAsync(string username);
    }
}
