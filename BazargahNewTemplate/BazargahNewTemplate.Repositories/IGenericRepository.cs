using BazargahNewTemplate.Domain;

namespace BazargahNewTemplate.Repositories
{
    public interface IGenericRepository<T>
        where T : IEntity
    {
        T Add(T entity);
        T GetSingle(Guid Id);
        T Update(T entity);
        T Delete(T entity);
        ICollection<T> List();
    }
}