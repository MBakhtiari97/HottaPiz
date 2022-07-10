using System.Linq.Expressions;
using HottaPiz.DataLayer.DTOs.Customer;
using HottaPiz.DataLayer.Entities.Customer;
using HottaPiz.Infrastructure.Services.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace HottaPiz.Web.Tests
{
    [TestClass]
    public class CustomerTests
    {
        public CustomerTests()
        {
            
        }

        readonly Mock<ICustomerServices> mock = new Mock<ICustomerServices>();

        #region Test Register Customer

        [TestMethod]
        public async Task ShouldRegisterUserAndReturnTrue()
        {

            //Arrange
            var newCustomer = new Customer()
            {
                CustomerEmailAddress = "test@test.com",
                CustomerFirstAddress = "test",
                CustomerFirstName = "test",
                CustomerPhoneNumber = "0912000000",
                CustomerSecondAddress = "test",
                CustomerLastName = "test",
                Password = "123",
                CustomerRegisterDate = DateTime.Now
            };

            mock.Setup(mock =>
                    mock.RegisterCustomer(newCustomer))
                .ReturnsAsync(true);

            //Act
            var actual = await mock.Object.RegisterCustomer(newCustomer);

            //Assert
            Assert.AreEqual(true, actual);
        }

        #endregion
    }
}
