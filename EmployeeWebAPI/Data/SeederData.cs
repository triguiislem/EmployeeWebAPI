using EmployeeWebAPI.Models;

namespace EmployeeWebAPI.Data
{
    public class SeederData
    {
        public static void seed( IApplicationBuilder applicationBuilder) {
        
        var servicescope=applicationBuilder.ApplicationServices.CreateScope();
        var context = servicescope.ServiceProvider.GetService<TP7Context>();
            context.Database.EnsureCreated();
            if (!context.Departments.Any()) {
                context.Departments.AddRange(
                    new List<Departement>()
                    {
                    new Departement() {DepartmentName="Production" },
                     new Departement() {DepartmentName="Logistique" } });
                context.SaveChanges(); 
                
            
            }
        
        }
    }
}
