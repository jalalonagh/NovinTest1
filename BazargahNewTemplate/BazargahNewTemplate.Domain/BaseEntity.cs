
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BazargahNewTemplate.Domain
{
    public abstract class BaseEntity : IEntity
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long Priority { get; set; }
    }
}
