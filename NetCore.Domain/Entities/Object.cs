using NetCore.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Domain.Entities
{
    public class Object : BaseEntity
    {
        public string? DisplayName { get; set; }
        public string? QRCode { get; set; }
        public string? BarCode { get; set; }
    }
}
