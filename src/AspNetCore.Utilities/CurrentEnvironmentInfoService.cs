using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Hosting;
using ICG.AspNetCore.Utilities.Models;
using Microsoft.Extensions.Configuration;

namespace ICG.AspNetCore.Utilities
{
    /// <summary>
    /// This service will provide information on the current application environment.  Useful for displaying information to admin users, etc.
    /// </summary>
    public interface ICurrentEnvironmentInfoService
    {
        /// <summary>
        /// Loads the information for the current environment as well for each of the supplied connection strings
        /// </summary>
        /// <param name="connectionStringKeyNames">A listing of ConnectionString names to load information on</param>
        /// <returns>A hydrated <see cref="CurrentEnvironmentModel"/> for the application</returns>
        CurrentEnvironmentModel GetCurrentEnvironment(List<string> connectionStringKeyNames);
    }

    /// <inheritdoc />
    public class CurrentEnvironmentInfoService : ICurrentEnvironmentInfoService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IConfiguration _configuration;
        private readonly IDatabaseEnvironmentModelFactory _databaseEnvironmentModelFactory;

        /// <summary>
        /// Default constructor with required DI parameters
        /// </summary>
        /// <param name="hostingEnvironment">The current hosting environment information</param>
        /// <param name="configuration">The current configuration</param>
        /// <param name="databaseEnvironmentModelFactory">Factory to create new objects</param>
        public CurrentEnvironmentInfoService(IWebHostEnvironment hostingEnvironment, IConfiguration configuration, IDatabaseEnvironmentModelFactory databaseEnvironmentModelFactory)
        {
            _hostingEnvironment = hostingEnvironment;
            _configuration = configuration;
            _databaseEnvironmentModelFactory = databaseEnvironmentModelFactory;
        }

        /// <inheritdoc />
        public CurrentEnvironmentModel GetCurrentEnvironment(List<string> connectionStringKeyNames)
        {
            //Lookup the DB items
            var dbList = new List<DatabaseEnvironmentModel>();
            if (connectionStringKeyNames != null)
            {
                foreach (var keyName in connectionStringKeyNames)
                {
                    dbList.Add(_databaseEnvironmentModelFactory.CreateFromConnectionString(keyName,
                        _configuration.GetConnectionString(keyName)));
                }
            }

            return new CurrentEnvironmentModel
            {
                ApplicationName = _hostingEnvironment.ApplicationName,
                ApplicationRootPath = _hostingEnvironment.ContentRootPath,
                WebRootPath = _hostingEnvironment.WebRootPath,
                EnvironmentName = _hostingEnvironment.EnvironmentName,
                FrameworkDescription = RuntimeInformation.FrameworkDescription,
                OperatingSystemDescription = RuntimeInformation.OSDescription,
                ProcessorArchitecture = RuntimeInformation.ProcessArchitecture.ToString(),
                Databases = dbList
            };
        }
    }
}
