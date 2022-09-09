using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Artsoft.DataAccess.Models.Entities
{
    //TODO Must be record instead class. Current version of automapper don't support records
    [Table("Employee")]
    public class Employee
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; init; }
        public string Name { get; init; }
        public string Surname { get; init; }
        public int Age { get; init; }
        public int Gender { get; init; }
        public Department Department { get; init; }
        public ProgrammingLanguage ProgrammingLanguage { get; init; }
    }
}