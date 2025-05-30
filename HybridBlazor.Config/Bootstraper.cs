using HybridBlazor.Infrastructure.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HybridBlazor.Config;

public static class Bootstraper
{
    public static void Run(this IServiceCollection service, IConfiguration configuration)
    {
        service.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("Idp4Connection")));
    }
}
