using Microsoft.AspNetCore.Builder;
using Serilog;

namespace FEWA.Infrastructure.Logging;

public static class SerilogExtensions
{
    public static WebApplicationBuilder WithLogger(this WebApplicationBuilder builder)
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();
        builder.Host.UseSerilog();
        return builder;
      
    }
}