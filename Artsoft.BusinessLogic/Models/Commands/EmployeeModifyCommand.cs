using Artsoft.BusinessLogic.Enums;

namespace Artsoft.BusinessLogic.Models.Commands
{
    public class EmployeeModifyCommand
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid ProgrammingLanguageId { get; set; }
    }
}