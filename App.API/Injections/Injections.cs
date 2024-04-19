using System.BussinessRules;
using System.Providers;

namespace App.API.Injections
{
    internal static class Injections
    {

        #region BussinessRules
        public static void InjectRules(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<LogBusinessRules>();
        }
        #endregion

        #region Providers
        public static void InjectProviders(WebApplicationBuilder builder)
        {
            ProcessInjection<LogBusinessRules>(builder);
        }
        #endregion

        private static void ProcessInjection<T>(WebApplicationBuilder builder) where T : class
        {
            builder.Services.AddScoped<T>(provider =>
            {
                var dbContext = provider.GetRequiredService<EntityContext>();
                return Activator.CreateInstance(typeof(T), dbContext) as T;
            });
        }
    }
}
