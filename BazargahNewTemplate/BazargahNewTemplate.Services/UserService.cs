using BazargahNewTemplate.Domain.UserEntities;
using BazargahNewTemplate.Repositories;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
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

        public User Register(User entity)
        {
            if (entity == null && entity.Id != Guid.Empty)
                throw new ArgumentException("@UserService.AddService.NullException");

            // Generic Logs

            return repository.Add(entity);
        }

        public User DeleteService(User entity)
        {
            if(!string.IsNullOrEmpty(entity.Email))
                throw new ArgumentException("@UserService.DeleteService.EmailExistDeleteException");

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

        public User Login(string username, string password)
        {
            var found = ListService().FirstOrDefault(w => w.UserName == username && w.Password == password);

            if (found == null)
                throw new ArgumentException("@UserService.Login.UserNotFound");

            return found;
        }
    }
}
