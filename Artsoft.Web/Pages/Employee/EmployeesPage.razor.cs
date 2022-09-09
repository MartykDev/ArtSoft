using Artsoft.BusinessLogic.Services.Interfaces;
using Artsoft.Web.Components;
using Common.Mapper.Extensions;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System.ComponentModel;

using WebModel = Artsoft.Web.Models;

namespace Artsoft.Web.Pages.Employee
{
    public partial class EmployeesPage : ArtsoftComponentBase
    {
        [Inject] public IEmployeeService EmployeeService { get; set; }

        public IReadOnlyCollection<WebModel.Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetAllAsync(CancellationToken))
                            .MapRangeTo<WebModel.Employee>()
                            .ToList();
        }

    }
}