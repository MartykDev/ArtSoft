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
        #region Services

        [Inject] public IEmployeeService EmployeeService { get; set; }
        [Inject] public IDepartmentService DepartmentService { get; set; }
        [Inject] public IProgrammingLanguageService ProgrammingLanguageService { get; set; }

        #endregion

        public WebModel.EmployeeModifyInput EmployeeModifyInput { get; set; }
        public IReadOnlyCollection<WebModel.Department> Departments { get; set; }
        public IReadOnlyCollection<WebModel.ProgrammingLanguage> ProgrammingLanguages { get; set; }

        protected override async Task OnInitializedAsync()
        {
            EmployeeModifyInput = new();

            var departmentsTask = DepartmentService.GetAllAsync(CancellationToken);
            var programmingLanguagesTask = ProgrammingLanguageService.GetAllAsync(CancellationToken);

            await Task.WhenAll(departmentsTask, programmingLanguagesTask);

            Departments = departmentsTask.Result.MapRangeTo<WebModel.Department>().ToList();
            ProgrammingLanguages = programmingLanguagesTask.Result.MapRangeTo<WebModel.ProgrammingLanguage>().ToList();

            Initialized = true;
        }

        public async Task ModifyEmployeeAsync()
        {
            await EmployeeService.CreateAsync(EmployeeModifyInput.MapTo<BlCommands.EmployeeModifyCommand>(), CancellationToken);
        }
    }
}