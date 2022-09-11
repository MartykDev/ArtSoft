namespace Artsoft.DataAccess.Models.Commands
{
    public class EmployeeModifyCommand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid ProgrammingLanguageId { get; set; }
    }
}