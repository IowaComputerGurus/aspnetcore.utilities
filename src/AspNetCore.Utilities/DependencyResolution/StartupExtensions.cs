﻿using ICG.AspNetCore.Utilities;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// 
    /// </summary>
    public static class StartupExtensions
    {
        /// <summary>
        /// Registers the items included in the ICG AspNetCore Utilities project for Dependency Injection
        /// </summary>
        /// <param name="services">Your existing services collection</param>
        public static void UseIcgAspNetCoreUtilities(this IServiceCollection services)
        {
            //BLOG: Needed to add Install-Package Microsoft.Extensions.Options.ConfigurationExtensions
            //Bind additional services
            services.AddTransient<IUrlSlugGenerator, UrlSlugGenerator>();
            services.AddTransient<ITimeProvider, TimeProvider>();
            services.AddTransient<ITimeSpanProvider, TimeSpanProvider>();
            services.AddTransient<IPathProvider, PathProvider>();
        }
    }
}