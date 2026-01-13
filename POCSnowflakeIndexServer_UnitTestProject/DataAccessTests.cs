using POCSnowflakeIndexServer.DAL;

namespace POCSnowflakeIndexServer_UnitTestProject
{
    public class Tests
    {
        private SnowflakeDataAccess _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new SnowflakeDataAccess
            {
                ConnectionString = "Server=account.snowflakecomputing.com;User Id=test;Password=secret;"
            };
        }

        [TearDown]
        public void TearDown()
        {
            _sut?.Dispose();
        }

        [Test]
        public void ConnectionString_IsInitialized_InSetUp()
        {
            Assert.That(_sut.ConnectionString, Is.EqualTo(
                "Server=account.snowflakecomputing.com;User Id=test;Password=secret;"));
        }
    }
}

