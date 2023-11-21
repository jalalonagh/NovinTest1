
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BazargahNewTemplate.Domain
{
    public abstract class BaseEntity<T> : IEntity<T>
        where T : struct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long Priority { get; set; }
    }
}
