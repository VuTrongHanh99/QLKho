using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.SqlServer.Systems
{
    public class Object_DoiTuong
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Required]
        [StringLength(128)]
        [Column("DisplayName")]
        public string? DisplayName { get; set; }
        [Required]
        [StringLength(128)]
        [Column("QRCode")]
        public string? QRCode { get; set; }
        [Required]
        [StringLength(128)]
        [Column("BarCode")]
        public string? BarCode { get; set; }

        //IdUnit
        //IdSuplier
    }
}
