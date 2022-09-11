using Artsoft.BusinessLogic.Services.Interfaces;
using Microsoft.AspNetCore.Components;

using WebModels = Artsoft.Web.Models;
using BlCommands = Artsoft.BusinessLogic.Models.Commands;
using Common.Mapper.Extensions;
using System;

namespace Artsoft.Web.Pages.Employee
{
    public partial class EmployeeEdit
    {
        #region Injections

        [Inject] public NavigationManager NavigationManager { get; set; }
        [Inject] public IEmployeeService EmployeeService { get; set; }

        #endregion

        [Parameter] public string EmployeeStringId { get; set; }
        private Guid employeeId;

        public WebModels.EmployeeModifyInput EmployeeModifyInput { get; set; }

        protected override async Task OnInitializedAsync()
        {
            employeeId = new Guid(EmployeeStringId);

            EmployeeModifyInput = (await EmployeeService.GetByIdAsync(employeeId, CancellationToken))
                                       .MapTo<WebModels.EmployeeModifyInput>();
            Initialized = true;
        }

        public async Task EditEmployeeAsync()
        {
            await EmployeeService.UpdateAsync(employeeId, EmployeeModifyInput.MapTo<BlCommands.EmployeeModifyCommand>(), CancellationToken);
            NavigationManager.NavigateTo("/");
        }
    }
}
