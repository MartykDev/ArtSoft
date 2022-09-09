using Common.Mapper.Extensions;

using Microsoft.AspNetCore.Components;

using Artsoft.Web.Components;
using Artsoft.BusinessLogic.Services.Interfaces;

using WebModel = Artsoft.Web.Models;

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

            //Departments = (await DepartmentService.GetAllAsync(CancellationToken))
            //               .MapRangeTo<WebModel.Department>()
            //               .ToList();

            ProgrammingLanguages = (await ProgrammingLanguageService.GetAllAsync(CancellationToken))
                                    .MapRangeTo<WebModel.ProgrammingLanguage>()
                                    .ToList();
        }
    }
}