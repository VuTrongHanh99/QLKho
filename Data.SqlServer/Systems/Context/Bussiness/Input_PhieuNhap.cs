using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.SqlServer.Systems
{
    public class Input_PhieuNhap
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("DateInput")]
        public DateTime? DateInput { get; set; }
    }
}
