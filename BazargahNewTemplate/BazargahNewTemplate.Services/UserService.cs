using BazargahNewTemplate.Domain.UserEntities;
using BazargahNewTemplate.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazargahNewTemplate.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository repository;

        public UserService(IUserRepository _repository)
        {
            repository = _repository;
        }

        public User AddService(User entity)
        {
            // Generic Validations

            // Generic Logs

            return repository.Add(entity);
        }

        public User DeleteService(User entity)
        {
            // Generic Validations

            // Generic Logs

            return repository.Delete(entity);
        }

        public User GetSingleService(Guid Id)
        {
            // Generic Validations

            // Generic Logs

            return repository.GetSingle(Id);
        }

        public ICollection<User> ListService()
        {
            // Generic Validations

            // Generic Logs

            return repository.List();
        }

        public User UpdateService(User entity)
        {
            // Generic Validations

            // Generic Logs

            return repository.Update(entity);
        }
    }
}
