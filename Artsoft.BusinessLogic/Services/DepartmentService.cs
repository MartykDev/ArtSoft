using Common.Mapper.Extensions;

using Artsoft.BusinessLogic.Services.Interfaces;
using Artsoft.DataAccess.Repositories.Interfaces;

using BlModels = Artsoft.BusinessLogic.Models;

namespace Artsoft.BusinessLogic.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
            => this.departmentRepository = departmentRepository;

        public async Task<IEnumerable<BlModels.Department>> GetAllAsync(CancellationToken cancellationToken)
            => (await departmentRepository.GetAllAsync(cancellationToken)).MapRangeTo<BlModels.Department>();
    }
}