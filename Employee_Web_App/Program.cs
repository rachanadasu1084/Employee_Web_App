using Microsoft.EntityFrameworkCore;
using Employee_Web_App.Repositories;
using Employee_Web_App.Services;
using Employee_Web_App.Endpoints;
using Employee_Web_App.Repository;

var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
     policy =>
     {
         policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
     });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseCors(MyAllowSpecificOrigins);

app.UseRouting();

//app.UseAuthorization();

app.MapEmployeeEndpoints();

app.Run();