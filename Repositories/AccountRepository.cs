using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppOrmEntity.Models;

namespace AppOrmEntity.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly List<User> _users = new List<User>
        {
            new User { Username = "admin", Password = "admin", Role = "Admin" },
            new User { Username = "user", Password = "user", Role = "User" }
        };

        public async Task<User> GetUserByUsernameAndPasswordAsync(string username, string password)
        {
            return await Task.FromResult(_users.FirstOrDefault(u => u.Username == username && u.Password == password));
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            return await Task.FromResult(_users.FirstOrDefault(u => u.Username == username));
        }
    }
}
