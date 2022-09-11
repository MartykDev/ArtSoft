using Common.Mapper.Extensions;

using Microsoft.AspNetCore.Components;

using Artsoft.Web.Components;
using Artsoft.BusinessLogic.Services.Interfaces;

using WebModel = Artsoft.Web.Models;
using System.Reflection.Metadata;

namespace Artsoft.Web.Pages.Employee
{
    public partial class EmployeeModifyForm : ArtsoftComponentBase
    {
        #region Injections

        [Inject] public IDepartmentService DepartmentService { get; set; }
        [Inject] public IProgrammingLanguageService ProgrammingLanguageService { get; set; }

        #endregion

        [Parameter] public string SubmitButtonText { get; set; } = "Add";
        [Parameter] public EventCallback ModifyActionAsync { get; set; }
        [Parameter] public WebModel.EmployeeModifyInput EmployeeModifyInput { get; set; }

        public IReadOnlyCollection<WebModel.Department> Departments { get; set; }
        public IReadOnlyCollection<WebModel.ProgrammingLanguage> ProgrammingLanguages { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var departmentsTask = DepartmentService.GetAllAsync(CancellationToken);
            var programmingLanguagesTask = ProgrammingLanguageService.GetAllAsync(CancellationToken);

            await Task.WhenAll(departmentsTask, programmingLanguagesTask);

            Departments = departmentsTask.Result.MapRangeTo<WebModel.Department>().ToList();
            ProgrammingLanguages = programmingLanguagesTask.Result.MapRangeTo<WebModel.ProgrammingLanguage>().ToList();

            Initialized = true;
        }
    }
}