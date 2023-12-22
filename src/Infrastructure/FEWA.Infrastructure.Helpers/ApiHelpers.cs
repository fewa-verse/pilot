using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace FEWA.Infrastructure.Helpers;

public static class ApiHelpers
{
    public static  RouteHandlerBuilder  MapVersionEndpoint(this IEndpointRouteBuilder app)
    {
        return app.MapGet("/version", () => 
            Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "Unknown Version");
    }
}