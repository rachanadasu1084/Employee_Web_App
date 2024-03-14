using Microsoft.AspNetCore.Mvc;
using Employee_Web_App.Models;
using Employee_Web_App.Services;
using Microsoft.AspNetCore.Http;

namespace Employee_Web_App.Endpoints
{
    public static class EmployeeEndpoints
    {
        public static WebApplication MapEmployeeEndpoints(this WebApplication app)
        {
            app.MapGet("/employee", async (IEmployeeService employeeService) =>
            {
                var response = await employeeService.GetAllEmployeesAsync();
                return Results.Ok();
            });

            app.MapPost("/employee/create", async (IEmployeeService employeeService, [FromBody] Employee request) =>
            {
                var response = await employeeService.AddEmployeeAsync(request);
                return Results.Ok();
            });

            app.MapPut("/employee/update", async (IEmployeeService employeeService, [FromBody] Employee request) =>
            {
                
                var response = await employeeService.UpdateEmployeeAsync(request.Id, request);
                return Results.Ok();
            });

            app.MapDelete("/employee/delete/{id}", async (IEmployeeService employeeService, [FromRoute] int id) =>
            {
                var response = await employeeService.DeleteEmployeeAsync(id);
                return Results.Ok();
            });

            return app;
        }
    }
}