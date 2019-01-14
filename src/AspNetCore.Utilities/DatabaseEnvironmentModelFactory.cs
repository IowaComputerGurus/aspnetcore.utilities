using System;
using ICG.AspNetCore.Utilities.Models;

namespace ICG.AspNetCore.Utilities
{
    /// <summary>
    /// A factory to create <see cref="DatabaseEnvironmentModel"/> objects
    /// </summary>
    public interface IDatabaseEnvironmentModelFactory
    {
        /// <summary>
        /// Creates a <see cref="DatabaseEnvironmentModel"/> object from a supplied connectionString
        /// </summary>
        /// <param name="keyName">The string name of the key</param>
        /// <param name="connectionString">The connection string</param>
        /// <returns>Limited information for display</returns>
        DatabaseEnvironmentModel CreateFromConnectionString(string keyName, string connectionString);
    }

    /// <inheritdoc />
    public class DatabaseEnvironmentModelFactory : IDatabaseEnvironmentModelFactory
    {
        /// <inheritdoc />
        public DatabaseEnvironmentModel CreateFromConnectionString(string keyName, string connectionString)
        {
            var dbInfo = new DatabaseEnvironmentModel { ConnectionStringName = keyName };
            var parts = connectionString.Split(';');
            foreach (var part in parts)
            {
                var items = part.Split('=');
                if (items.Length != 2)
                    continue;

                //Process known items
                if (items[0].Equals("server", StringComparison.OrdinalIgnoreCase))
                    dbInfo.ServerName = items[1];
                if (items[0].Equals("data source", StringComparison.OrdinalIgnoreCase))
                    dbInfo.ServerName = items[1];
                if (items[0].Equals("database", StringComparison.OrdinalIgnoreCase))
                    dbInfo.DatabaseName = items[1];
                if (items[0].Equals("initial catalog", StringComparison.OrdinalIgnoreCase))
                    dbInfo.DatabaseName = items[1];
            }
            return dbInfo;
        }
    }
}
