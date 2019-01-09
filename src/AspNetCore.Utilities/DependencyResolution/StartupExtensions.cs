using ICG.AspNetCore.Utilities;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class StartupExtensions
    {
        public static void UseIcgAspNetCoreUtilities(this IServiceCollection services)
        {
            //BLOG: Needed to add Install-Package Microsoft.Extensions.Options.ConfigurationExtensions
            //Bind additional services
            services.AddTransient<IUrlSlugGenerator, UrlSlugGenerator>();
            services.AddTransient<ITimeProvider, TimeProvider>();
            services.AddTransient<ITimeSpanProvider, TimeSpanProvider>();
        }
    }
}