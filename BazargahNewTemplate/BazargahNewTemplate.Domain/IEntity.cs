namespace BazargahNewTemplate.Domain
{
    public interface IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long Priority { get; set; }
    }
}