namespace BazargahNewTemplate.Domain
{
    public interface IEntity
    {
        public DateTime CreationTime { get; set; }
        public long Priority { get; set; }
    }

    public interface IEntity<T> : IEntity
        where T : struct
    {
        public T Id { get; set; }
    }
}