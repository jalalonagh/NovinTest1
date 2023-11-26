using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazargahNewTemplate.Domain.UserEntities
{   public class UserAddress : BaseEntity
    {
        public Guid UserId { get; set; }
        public required string Address { get; set; }
        public required string Province { get; set; }
        public required string City { get; set; }
    }
}
