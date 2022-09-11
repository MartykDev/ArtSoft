using Common.Mapper.Extensions;

using Microsoft.AspNetCore.Components;

using Artsoft.Web.Components;
using Artsoft.BusinessLogic.Services.Interfaces;

using WebModel = Artsoft.Web.Models;
using BlCommands = Artsoft.BusinessLogic.Models.Commands;

namespace Artsoft.Web.Pages.Employee
{
    public partial class EmployeeAdd : ArtsoftComponentBase
    {
        #region Injections

        [Inject] public NavigationManager NavigationManager { get; set; }
        [Inject] public IEmployeeService EmployeeService { get; set; }

        #endregion

        public WebModel.EmployeeModifyInput EmployeeModifyInput { get; set; }

        protected override void OnInitialized()
        {
            EmployeeModifyInput = new();
            Initialized = true;
        }

        public async Task AddEmployeeAsync()
        {
            await EmployeeService.CreateAsync(EmployeeModifyInput.MapTo<BlCommands.EmployeeModifyCommand>(), CancellationToken);
            NavigationManager.NavigateTo("/");
        }
    }
}