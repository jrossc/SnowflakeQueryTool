using POCSnowflakeIndexServer.Controllers;
using POCSnowflakeIndexServer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCSnowflakeIndexServer_UnitTestProject
{
    public class QueryAsParametertTests
    {
        private QueryAsParameterController _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new QueryAsParameterController("<insert connection string here>");
        }

        [TearDown]
        public void TearDown()
        {
            _sut = null;
        }

        [Test]
        public async Task Get_WithValidCommand_ShouldReturnResult()
        {
            // Arrange
            var command = "SELECT * from table";

            // Act
            var result = await _sut.Get(command);

            // Assert
            Assert.That(result, Is.Not.Null);
        }
    }
}
