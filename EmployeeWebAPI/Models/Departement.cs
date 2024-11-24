using System.ComponentModel.DataAnnotations;

namespace EmployeeWebAPI.Models
{
    public class Departement
    {
        [Key]

        public int DepartmentId { get; set; }
        [Required]
        [StringLength(50)]
        [MinLength(5,ErrorMessage ="au moins 5 caractere")]
        public string DepartmentName { get; set; }
    }
}
