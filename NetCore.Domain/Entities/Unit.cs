using NetCore.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Domain.Entities
{
    public class Unit : BaseEntity
    {
        public string? DisplayName { get; set; }
    }
}
