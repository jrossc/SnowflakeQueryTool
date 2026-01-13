using POCSnowflakeIndexServer.DAL;
using System.Data;

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

        public void Connection_MustConnect()
        {
            string result = "";

            result = _sut.TestConnection();

            Assert.That(result.Contains("Connection Established"), Is.EqualTo(true));
        }

        public void Connection_MustNotConnect()
        {
            string result = "";

            result = _sut.TestConnection();

            Assert.That(result.Contains("Failed to establish"), Is.EqualTo(true));
        }

        public void GetData_IsNotNull()
        {
            DataTable result = new DataTable();

            result = _sut.GetData("select * from table");

            Assert.That(result.Rows.Count, Is.EqualTo(1));
        }

        public void GetDataJSON_IsNull()
        {
            string result = "";

            result = _sut.GetDataJSON("select * from table");

            Assert.That(result.Length, Is.GreaterThan(0));
        }
    }
}

