using System.ComponentModel.DataAnnotations;

namespace Artsoft.Web.Models
{
    public class EmployeeModifyInput
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        [Range(18, 65, ErrorMessage = "Please enter the correct value in range 18 - 65")]
        public int? Age { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public Guid? DepartmentId { get; set; }

        [Required]
        public Guid? ProgrammingLanguageId { get; set; }
    }
}