using Artsoft.BusinessLogic.Services.Interfaces;
using Artsoft.Web.Components;
using Common.Mapper.Extensions;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using System.ComponentModel;

using WebModel = Artsoft.Web.Models;

namespace Artsoft.Web.Pages.Employee
{
    public partial class EmployeesPage : ArtsoftComponentBase
    {
        private const string confirmQuestion = "Are you sure you want to delete employee {0} ?";

        #region Injections

        [Inject] public IJSRuntime JSRuntime { get; set; }

        [Inject] public IEmployeeService EmployeeService { get; set; }

        #endregion

        public IReadOnlyCollection<WebModel.Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await RetriveEmployeesListAsync();
            Initialized = true;
        }

        public async Task DeleteEmployeeAsync(Guid employeeId, string employeeFullName)
        {
            var isConfirmed = await JSRuntime.InvokeAsync<bool>("confirm", string.Format(confirmQuestion, employeeFullName));

            if (!isConfirmed)
                return;

            await EmployeeService.DeleteAsync(employeeId, CancellationToken);
            await RetriveEmployeesListAsync();
        }

        private async Task RetriveEmployeesListAsync()
        {
            Employees = (await EmployeeService.GetAllAsync(CancellationToken))
                            .MapRangeTo<WebModel.Employee>()
                            .ToList();
        }
    }
}