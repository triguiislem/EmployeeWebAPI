namespace EmployeeWebAPI.Models.Repository
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetAll();
        Task<Employee> GetById(int id);
        Task<Employee> Add(Employee employee);
        Task update(Employee employee);
        Task Delete(Employee employee);



       

    }
}
