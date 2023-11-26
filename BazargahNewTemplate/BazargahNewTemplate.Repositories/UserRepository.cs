using BazargahNewTemplate.Domain.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazargahNewTemplate.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public string GetUserAvatar(string username, string password)
        {
            return "/wwwroot/avatars/onagh.jpg";
        }
    }
}
