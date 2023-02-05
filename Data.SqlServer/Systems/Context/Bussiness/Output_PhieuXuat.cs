using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.SqlServer.Systems
{
    public class Output_PhieuXuat
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("DateOutput")]
        public DateTime? DateOutput { get; set; }
    }
}
