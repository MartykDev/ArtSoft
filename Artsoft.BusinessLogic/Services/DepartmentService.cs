using Artsoft.BusinessLogic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BlModels = Artsoft.BusinessLogic.Models;

namespace Artsoft.BusinessLogic.Services
{
    public class DepartmentService : IDepartmentService
    {
        public Task<IEnumerable<BlModels.Department>> GetAllAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}