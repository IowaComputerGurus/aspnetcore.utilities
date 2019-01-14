using System.ComponentModel.DataAnnotations;

namespace ICG.AspNetCore.Utilities.Models
{
    /// <summary>
    /// Represents a database inside the application
    /// </summary>
    public class DatabaseEnvironmentModel
    {
        /// <summary>
        /// The name of the connection string being described
        /// </summary>
        [Display(Name = "Connection Name")]
        public string ConnectionStringName { get; set; }

        /// <summary>
        /// The name of the database connecting to
        /// </summary>
        [Display(Name = "Database Name")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// The name of the server used
        /// </summary>
        [Display(Name = "Server")]
        public string ServerName { get; set; }
    }
}