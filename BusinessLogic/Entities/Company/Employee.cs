using BusinessLogic.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.Entities.Company
{
    [Table("Employees")]
    public class Employee : AuditableBaseEntity<long>
    {
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        public DateTime? DOB { get; set; }

        [Column("DeptId")]
        public long DeptId { get; set; }

        [Column("PositionId")]
        public long PositionId { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        public DateTime? HireDate { get; set; }

        public byte Status { get; set; }
    }
}
