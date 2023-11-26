using BazargahNewTemplate.Domain;

namespace BazargahNewTemplate.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T>
        where T : IEntity
    {
        private static List<T> VirtualDB { get; set; } = new List<T>();

        public T Add(T entity)
        {
            entity.Id = Guid.NewGuid();
            VirtualDB.Add(entity);
            return entity;
        }

        public T Delete(T entity)
        {
            if (CheckDataIsNull(entity))
                return default(T);

            var found = VirtualDB.FirstOrDefault(f => f.Id == entity.Id);

            if (found != null)
                VirtualDB = VirtualDB.Where(w => w.Id != entity.Id).ToList();

            return found;
        }

        public T GetSingle(Guid Id)
        {
            if (Id == Guid.Empty)
                return default(T);

            return VirtualDB.FirstOrDefault(f => f.Id == Id);
        }

        public ICollection<T> List()
        {
            return VirtualDB;
        }

        public T Update(T entity)
        {
            if (CheckDataIsNull(entity))
                return default(T);

            var found = VirtualDB.FirstOrDefault(f => f.Id == entity.Id);

            if (found == null)
                return default(T);

            VirtualDB = VirtualDB.Where(w => w.Id != found.Id).ToList();

            VirtualDB.Add(entity);

            return GetSingle(entity.Id);
        }

        private bool CheckDataIsNull(T entity)
        {
            return entity == null || entity.Id == Guid.Empty;
        }

        private void CheckDataIsNullException(T entity)
        {
            if (entity == null || entity.Id == Guid.Empty)
                throw new Exception("data is null.");
        }
    }
}
