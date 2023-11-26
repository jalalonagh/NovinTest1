using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazargahNewTemplate.Domain.UserEntities
{
    public class UserPhone : BaseEntity
    {
        public Guid UserId { get; set; }
        public required string PhoneNumber { get; set; }
        public required string PhoneNumberType { get; set; }
    }
}
