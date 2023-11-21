using BazargahNewTemplate.Domain;

namespace BazargahNewTemplate.Repositories
{
    public interface IGenericRepository<T>
        where T : IEntity
    {
        T Add(T entity);
        T GetSingle<P>(P Id);

    }
}