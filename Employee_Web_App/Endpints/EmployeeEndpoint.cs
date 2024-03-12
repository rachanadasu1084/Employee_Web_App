using Microsoft.AspNetCore.Mvc;
using Employee_Web_App.Models;
using Employee_Web_App.Services;
using Microsoft.AspNetCore.Http;

namespace Employee_Web_App.Endpoints
{
    public static class EmployeeEndpoints
    {
        public static void MapEmployeeEndpoints(this WebApplication app)
        {
            object value = app.MapGet("/employee", async (HttpContext context, IEmployeeService employeeService) =>
            {
                return await employeeService.GetAllEmployeesAsync();
            });

            /*app.MapGet("/employee/{id}", async (HttpContext context, IEmployeeService employeeService, int id) =>
            {
                var employee = await employeeService.GetEmployeeByIdAsync(id);
                if (employee == null)
                    return new NotFoundObjectResult("Sorry, employee doesn't exist.");
                return new OkObjectResult(employee);
            });*/

            app.MapPost("/employee/add", async (HttpContext context, IEmployeeService employeeService) =>
            {
                var employee = await context.Request.ReadFromJsonAsync<Employee>();
                var addedEmployee = await employeeService.AddEmployeeAsync(employee);
                return new CreatedResult(location: $"/employee/{addedEmployee.Id}", addedEmployee);
            });

            /*app.MapPut("/employee/{id}", async (HttpContext context, IEmployeeService employeeService, int id) =>
            {
                var updatedEmployee = await context.Request.ReadFromJsonAsync<Employee>();
                var result = await employeeService.UpdateEmployeeAsync(id, updatedEmployee);
                if (result == null)
                    return new NotFoundObjectResult("Sorry, employee doesn't exist.");
                return new OkObjectResult(result);
            });

            app.MapDelete("/employee/{id}", async (HttpContext context, IEmployeeService employeeService, int id) =>
            {
                var deletedEmployee = await employeeService.DeleteEmployeeAsync(id);
                if (deletedEmployee == null)
                    return new NotFoundObjectResult("Sorry, employee doesn't exist.");
                return new OkObjectResult(deletedEmployee);
            });*/
        }
    }
}