using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BusinessLogic.Entities.Base;

namespace BusinessLogic.Entities.Company
{
    [Table("Positions")]
    public class Position : AuditableBaseEntity<long>
    {
        [Required]
        [StringLength(100)]
        [Column("PositionName")]
        public string PositionName { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
    }
}
