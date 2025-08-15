using BusinessLogic.Dtos.Requests.Department;
using BusinessLogic.Dtos.Responses.Department;
using BusinessLogic.Wrapper;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IDepartmentService
    {
        Task<PaginatedResult<DepartmentResponse>> GetPagination(DepartmentRequest request);

        Task<Result<DepartmentResponse>> GetById(long id);

        Task<IResult> Add(DepartmentResponse request);

        Task<IResult> Update(DepartmentResponse request);

        Task<IResult> Delete(long id);
    }
}
