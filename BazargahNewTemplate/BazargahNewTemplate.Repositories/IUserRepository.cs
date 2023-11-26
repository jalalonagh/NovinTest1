using BazargahNewTemplate.Domain.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazargahNewTemplate.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        string GetUserAvatar(string username, string password);
    }
}
