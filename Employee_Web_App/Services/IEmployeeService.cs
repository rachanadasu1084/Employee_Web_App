using Employee_Web_App.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Employee_Web_App.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAllEmployeesAsync();
        Task<Employee> GetEmployeeByIdAsync(int id);
        Task<Employee> AddEmployeeAsync(Employee employee);
        Task<Employee> UpdateEmployeeAsync(int id, Employee updatedEmployee);
        Task<Employee> DeleteEmployeeAsync(int id);
    }
}

