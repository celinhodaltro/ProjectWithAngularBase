using System.BussinessRules;
using System.Providers;

namespace App.API.Injections
{
    internal static class Injections
    {
        public static void InjectRules(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<LogBusinessRules>();
        }

        public static void InjectProviders(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<LogProvider>(provider =>
            {
                var dbContext = provider.GetRequiredService<EntityContext>();
                return new LogProvider(dbContext);
            });
        }
    }
}
