using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.SqlServer.Systems
{
    public class Suplier_NhaCungCap
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Required]
        [StringLength(128)]
        [Column("DisplayName")]
        public string? DisplayName { get; set; }
        [Column("Address")]
        public string? Address { get; set; }
        [StringLength(128)]
        [Column("PhoneNumber")]
        public string? PhoneNumber { get; set; }
        [StringLength(128)]
        [Column("Email")]
        public string? Email { get; set; }
        //MoreInfo
        //ContractDate
    }
}
