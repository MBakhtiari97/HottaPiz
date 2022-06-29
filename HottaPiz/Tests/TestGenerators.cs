using HottaPiz.Infrastructure.Utilities.Generator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HottaPiz.Web.Tests
{
    [TestClass]
    public class TestGenerators
    {
        public TestGenerators()
        {
            
        }

        [TestMethod]
        public void ShouldNotBeNull()
        {
            //Act
            var generatedNumber = Generator.UniqueNumberGenerator();
            //Assert
            Assert.IsNotNull(generatedNumber);
        }
    }
}
