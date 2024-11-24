
using Microsoft.EntityFrameworkCore;

namespace EmployeeWebAPI.Models.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private  readonly TP7Context context;

        public EmployeeRepository(TP7Context context) {

            this.context = context;
        }
        public async Task<Employee> Add(Employee employee)
        {
           var result=await context.Employees.AddAsync(employee);
           await context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task Delete(Employee employee)
        {
        context.Remove(employee);
            await context.SaveChangesAsync();
        }

        public async Task<List<Employee>> GetAll()
        {
           return await context.Employees.ToListAsync();
        }

        public  async Task<Employee> GetById(int id)
        {
          Employee emp=await context.Employees.FindAsync(id);
            return emp;
        }

        public async Task update(Employee employee)
        {
           context.Employees.Update(employee);
            await context.SaveChangesAsync();

        }
    }
}
