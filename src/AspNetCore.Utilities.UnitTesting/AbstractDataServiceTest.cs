using Microsoft.EntityFrameworkCore;

namespace ICG.AspNetCore.Utilities.UnitTesting
{
    public abstract class AbstractDataServiceTest
    {
        public DbContextOptions<T> BuildMemoryDbOptions<T>(string dbName) where T : DbContext
        {
            return new DbContextOptionsBuilder<T>().UseInMemoryDatabase(dbName).Options;
        }
    }
}