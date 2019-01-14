using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ICG.AspNetCore.Utilities.Models
{
    /// <summary>
    ///     Provides condensed information regarding the current application environment
    /// </summary>
    public class CurrentEnvironmentModel
    {
        /// <summary>
        ///     The name of the application as derived from the Hosting Envrionment
        /// </summary>
        [Display(Name = "Application Name")]
        public string ApplicationName { get; set; }

        /// <summary>
        ///     The path to the web root folder
        /// </summary>
        [Display(Name = "WWW Root Path")]
        public string WebRootPath { get; set; }

        /// <summary>
        ///     The path to the application root folder
        /// </summary>
        [Display(Name = "Application Root Path")]
        public string ApplicationRootPath { get; set; }

        /// <summary>
        ///     The current environment name
        /// </summary>
        [Display(Name = "Environment Name")]
        public string EnvironmentName { get; set; }

        /// <summary>
        ///     The current runtime framework from <see cref="RuntimeInformation" />
        /// </summary>
        [Display(Name = "Framework")]
        public string FrameworkDescription { get; set; }

        /// <summary>
        ///     The current operating system description from <see cref="RuntimeInformation" />
        /// </summary>
        [Display(Name = "OS")]
        public string OperatingSystemDescription { get; set; }

        /// <summary>
        ///     The current processor architecture from <see cref="RuntimeInformation" />
        /// </summary>
        [Display(Name = "Processor Architecture")]
        public string ProcessorArchitecture { get; set; }

        /// <summary>
        ///     Information on the requested database connection strings
        /// </summary>
        public List<DatabaseEnvironmentModel> Databases { get; set; }
    }
}