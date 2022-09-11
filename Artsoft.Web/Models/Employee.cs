using Artsoft.BusinessLogic.Enums;

namespace Artsoft.Web.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string DepartmentName { get; set; }
        public string ProgrammingLanguageName { get; set; }

        public string FullName => $"{Name} {Surname}";
    }
}