using HottaPiz.Infrastructure.Security.PasswordHasher;
using HottaPiz.Infrastructure.Utilities.Generator;
using HottaPiz.Infrastructure.Utilities.PathTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HottaPiz.Web.Tests
{
    [TestClass]
    public class TestGenerators
    {
        #region Constructor

        public TestGenerators()
        {

        }

        #endregion

        #region Test generate random number

        [TestMethod]
        public void ShouldReturnRandomNumber()
        {
            //Act
            var generatedNumber = Generator.UniqueNumberGenerator();
            //Assert
            Assert.IsNotNull(generatedNumber);
        }

        #endregion

        #region Test get image path

        [TestMethod]
        public void ShouldReturnImagePath()
        {
            //Arrange
            var expected = "/images/pizza.png";
            //Act
            var actual = PathGenerator.GetPizzaImageAddress("pizza.png");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Test get save and delete path

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

        #endregion

        #region Test encode password

        [TestMethod]
        public void ShouldReturnHashedPassword()
        {
            //Arrange
            var password = "ABC123";
            //Act
            var hashedPassword = PasswordHelper.EncodePasswordMd5(password);
            //Assert
            Assert.IsNotNull(hashedPassword);
        }

        #endregion

    }
}
