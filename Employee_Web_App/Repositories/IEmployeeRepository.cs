using Employee_Web_App.Models;

namespace Employee_Web_App.Repository
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllEmployeesAsync();
        Task<Employee> GetEmployeeByIdAsync(int id);
        Task<Employee> AddEmployeeAsync(Employee employee);
        Task<Employee> UpdateEmployeeAsync(int id, Employee updatedEmployee);
        Task<Employee> DeleteEmployeeAsync(int id);
    }
}

