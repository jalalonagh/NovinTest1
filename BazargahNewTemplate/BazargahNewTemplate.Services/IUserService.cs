using BazargahNewTemplate.Domain.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazargahNewTemplate.Services
{
    public interface IUserService
    {
        User AddService(User entity);
        User GetSingleService(Guid Id);
        User UpdateService(User entity);
        User DeleteService(User entity);
        ICollection<User> ListService();
    }
}
