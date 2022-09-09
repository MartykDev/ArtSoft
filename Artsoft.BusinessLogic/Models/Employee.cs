using Artsoft.BusinessLogic.Enums;

namespace Artsoft.BusinessLogic.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string DepartmentName { get; set; }
        public string ProgrammingLanguageName { get; set; }
    }
}