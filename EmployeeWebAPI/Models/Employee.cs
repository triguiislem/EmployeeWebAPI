using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeWebAPI.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [StringLength(50)]

        public string FullName { get; set; }
        public DateTime DateofBirth { get; set; }
        public int DepartmentId { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        public Departement? Department { get; set; }
        



    }
}
