using Employee_Web_App.Endpoints;

namespace Employee_Web_App.Endpints
{
    public static class EndpointHandler
    {
        public static WebApplication ConfigureEndpoints(this WebApplication app)
        {
            app.MapEmployeeEndpoints();
            return app;
        }
    }
}
