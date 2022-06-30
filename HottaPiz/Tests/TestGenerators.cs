using HottaPiz.Infrastructure.Utilities.Generator;
using HottaPiz.Infrastructure.Utilities.PathTools;
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

        [TestMethod]
        public void ShouldReturnImagePath()
        {
            //Arrange
            var expected = "/images/pizza.png";
            //Act
            var actual = PathGenerator.GetPizzaImageAddress("pizza.png");
            //Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void ShouldReturnValidSavePath()
        {
            //Arrange
            var expected = "G:\\HottaPiz\\HottaPiz\\HottaPiz\\bin\\Debug\\net6.0/wwwroot/images/pizza.png";
            //Act
            var actual = PathGenerator.GetSaveAndDeletePizzaImage("pizza.png");
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
