using Xunit;

namespace ICG.AspNetCore.Utilities.Tests
{
    public class DatabaseEnvironmentModelFactoryTests
    {
        private readonly IDatabaseEnvironmentModelFactory _databaseEnvironmentModelFactory;

        public DatabaseEnvironmentModelFactoryTests()
        {
            _databaseEnvironmentModelFactory = new DatabaseEnvironmentModelFactory();
        }

        [Fact]
        public void CreateFromConnectionString_ShouldPassProvidedKeyIntoReturn()
        {
            //Arrange
            var key = "myKey";
            var myConnection = "testing";

            //Act
            var result = _databaseEnvironmentModelFactory.CreateFromConnectionString(key, myConnection);

            //Assert
            Assert.Equal(key, result.ConnectionStringName);
        }

        [Theory]
        [InlineData("Test", "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;", "myServerAddress")]
        [InlineData("Test", "Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;", "myServerAddress")]
        [InlineData("Test", "Server=myServerName\\myInstanceName;Database=myDataBase;User Id=myUsername;Password=myPassword;", "myServerName\\myInstanceName")]
        [InlineData("Test", "Data Source=190.190.200.100,1433;Network Library=DBMSSOCN;Initial Catalog=myDataBase;User ID=myUsername;Password=myPassword;", "190.190.200.100,1433")]
        public void CreateFromConnectionString_ShouldProperlyParseServer(string key, string connection, string expectedValue)
        {
            //Arrange

            //Act
            var result = _databaseEnvironmentModelFactory.CreateFromConnectionString(key, connection);

            //Assert
            Assert.Equal(expectedValue, result.ServerName);
        }

        [Theory]
        [InlineData("Test", "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;", "myDataBase")]
        [InlineData("Test", "Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;", "myDataBase")]
        [InlineData("Test", "Server=myServerName\\myInstanceName;Database=myDataBase;User Id=myUsername;Password=myPassword;", "myDataBase")]
        [InlineData("Test", "Data Source=190.190.200.100,1433;Network Library=DBMSSOCN;Initial Catalog=myDataBase;User ID=myUsername;Password=myPassword;", "myDataBase")]
        public void CreateFromConnectionString_ShouldProperlyParseDatabase(string key, string connection, string expectedValue)
        {
            //Arrange

            //Act
            var result = _databaseEnvironmentModelFactory.CreateFromConnectionString(key, connection);

            //Assert
            Assert.Equal(expectedValue, result.DatabaseName);
        }
    }
}
