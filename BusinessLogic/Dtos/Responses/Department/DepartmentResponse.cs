using System;

namespace BusinessLogic.Dtos.Responses.Department
{
    public class DepartmentResponse
    {
        public long Id { get; set; }
        public string DeptName { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
