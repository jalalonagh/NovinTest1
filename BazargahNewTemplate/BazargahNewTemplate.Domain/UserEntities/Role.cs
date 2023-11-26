using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazargahNewTemplate.Domain.UserEntities
{
    public class Role : BaseEntity
    {
        public required string Name { get; set; }
        public bool? IsActive { get; set; }
    }
}
