using BusinessLogic.Dtos.Requests.Department;
using BusinessLogic.Dtos.Responses.Department;
using BusinessLogic.Interfaces;
using BusinessLogic.Wrapper;
using BusinessLogic.Data;
using BusinessLogic.Entities.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class DepartmentService : IDepartmentService
    {
        private static List<Department> _departments;
        private static long _nextId = 51;

        static DepartmentService()
        {
            _departments = DataDepartment.GetDepartments().ToList();
        }

        public async Task<PaginatedResult<DepartmentResponse>> GetPagination(DepartmentRequest request)
        {
            try
            {
                var query = _departments.Where(d => !d.IsDeleted).AsQueryable();

                // Apply search filter
                if (!string.IsNullOrEmpty(request.Keyword))
                {
                    query = query.Where(d => d.DeptName.IndexOf(request.Keyword, StringComparison.OrdinalIgnoreCase) >= 0 
                                            || d.Description.IndexOf(request.Keyword, StringComparison.OrdinalIgnoreCase) >= 0);
                }

                var totalCount = query.Count();

                var pagedData = query.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToList();

                // Convert to DTOs
                var responseData = pagedData.Select(MapToResponse).ToList();

                return PaginatedResult<DepartmentResponse>.Success(responseData, totalCount, request.PageNumber, request.PageSize);
            }
            catch (Exception ex)
            {
                return PaginatedResult<DepartmentResponse>.Failure(new List<string> { $"Error retrieving departments: {ex.Message}" });
            }
        }

        public async Task<Result<DepartmentResponse>> GetById(long id)
        {
            try
            {
                var department = _departments.FirstOrDefault(d => d.Id == id && !d.IsDeleted);
                
                if (department == null)
                {
                    return Result<DepartmentResponse>.Fail($"Department with ID {id} not found");
                }

                var response = MapToResponse(department);
                return Result<DepartmentResponse>.Success(response, "Department retrieved successfully");
            }
            catch (Exception ex)
            {
                return Result<DepartmentResponse>.Fail($"Error retrieving department: {ex.Message}");
            }
        }

        public async Task<IResult> Add(DepartmentResponse request)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(request.DeptName))
                {
                    return Result.Fail("Department name is required");
                }

                if (request.DeptName.Length > 100)
                {
                    return Result.Fail("Department name cannot exceed 100 characters");
                }

                if (request.Description?.Length > 500)
                {
                    return Result.Fail("Description cannot exceed 500 characters");
                }

                if (_departments.Any(d => !d.IsDeleted && d.DeptName.Equals(request.DeptName, StringComparison.OrdinalIgnoreCase)))
                {
                    return Result.Fail("Department with this name already exists");
                }

                var newDepartment = new Department
                {
                    Id = _nextId++,
                    DeptName = request.DeptName.Trim(),
                    Description = request.Description?.Trim() ?? "",
                    CreatedBy = request.CreatedBy ?? "System",
                    CreatedOn = DateTime.Now,
                    LastModifiedBy = request.CreatedBy ?? "System",
                    LastModifiedOn = DateTime.Now,
                    IsDeleted = false
                };

                _departments.Add(newDepartment);

                return Result.Success("Department added successfully");
            }
            catch (Exception ex)
            {
                return Result.Fail($"Error adding department: {ex.Message}");
            }
        }

        public async Task<IResult> Update(DepartmentResponse request)
        {
            try
            {
                if (request.Id <= 0)
                {
                    return Result.Fail("Invalid department ID");
                }

                if (string.IsNullOrWhiteSpace(request.DeptName))
                {
                    return Result.Fail("Department name is required");
                }

                if (request.DeptName.Length > 100)
                {
                    return Result.Fail("Department name cannot exceed 100 characters");
                }

                if (request.Description?.Length > 500)
                {
                    return Result.Fail("Description cannot exceed 500 characters");
                }

                var existingDepartment = _departments.FirstOrDefault(d => d.Id == request.Id && !d.IsDeleted);
                
                if (existingDepartment == null)
                {
                    return Result.Fail($"Department with ID {request.Id} not found");
                }

                // Check for duplicate department name (excluding current department)
                if (_departments.Any(d => !d.IsDeleted && 
                    d.Id != request.Id &&
                    d.DeptName.Equals(request.DeptName, StringComparison.OrdinalIgnoreCase)))
                {
                    return Result.Fail("Department with this name already exists");
                }

                // Update department
                existingDepartment.DeptName = request.DeptName.Trim();
                existingDepartment.Description = request.Description?.Trim() ?? "";
                existingDepartment.LastModifiedBy = request.LastModifiedBy ?? "System";
                existingDepartment.LastModifiedOn = DateTime.Now;

                return Result.Success("Department updated successfully");
            }
            catch (Exception ex)
            {
                return Result.Fail($"Error updating department: {ex.Message}");
            }
        }

        public async Task<IResult> Delete(long id)
        {
            try
            {
                if (id <= 0)
                {
                    return Result.Fail("Invalid department ID");
                }

                var department = _departments.FirstOrDefault(d => d.Id == id && !d.IsDeleted);
                
                if (department == null)
                {
                    return Result.Fail($"Department with ID {id} not found");
                }

                // Soft delete
                department.IsDeleted = true;
                department.LastModifiedBy = "System";
                department.LastModifiedOn = DateTime.Now;

                return Result.Success("Department deleted successfully");
            }
            catch (Exception ex)
            {
                return Result.Fail($"Error deleting department: {ex.Message}");
            }
        }

        private DepartmentResponse MapToResponse(Department department)
        {
            return new DepartmentResponse
            {
                Id = department.Id,
                DeptName = department.DeptName,
                Description = department.Description,
                CreatedBy = department.CreatedBy,
                CreatedOn = department.CreatedOn,
                LastModifiedBy = department.LastModifiedBy,
                LastModifiedOn = department.LastModifiedOn,
                IsDeleted = department.IsDeleted
            };
        }
    }
}
