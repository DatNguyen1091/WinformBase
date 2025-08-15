using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BusinessLogic.Entities.Base;

namespace BusinessLogic.Entities.Company
{
    [Table("Departments")]
    public class Department : AuditableBaseEntity<long>
    {
        [Required]
        [StringLength(100)]
        [Column("DeptName")]
        public string DeptName { get; set; }

        [StringLength(500)]
        [Column("Description")]
        public string Description { get; set; }
    }
}
