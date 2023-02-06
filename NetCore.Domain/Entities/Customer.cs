using NetCore.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string? DisplayName { get; set; }
        //public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
    }
}
