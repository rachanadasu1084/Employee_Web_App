using System.Collections.Generic;
using System.Threading.Tasks;
using Employee_Web_App.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Employee_Web_App.Repository;
 
namespace Employee_Web_App.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await _employeeRepository.GetAllEmployeesAsync();
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            return await _employeeRepository.GetEmployeeByIdAsync(id);
        }

        public async Task<Employee> AddEmployeeAsync(Employee employee)
        {
            return await _employeeRepository.AddEmployeeAsync(employee);
        }

        public async Task<Employee> UpdateEmployeeAsync(int id, Employee updatedEmployee)
        {
            return await _employeeRepository.UpdateEmployeeAsync(id, updatedEmployee);
        }

        public async Task<Employee> DeleteEmployeeAsync(int id)
        {
            return await _employeeRepository.DeleteEmployeeAsync(id);
        }

        public Task<List<Employee>> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> UpdateEmployee(int id, Employee updatedEmployee)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }
    }
}