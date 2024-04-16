using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;
using HotelSOL.DAO;
using HotelSOL.Models;
using NHibernate;

namespace HotelSOLTEST
{
    [TestClass]
    public class DAOImplTests
    {
        [TestMethod]
        public void GetById_Returns_Entity()
        {
            // Arrange
            var mockSession = new Mock<ISession>();
            var dao = new DAOimpl<Customer>(mockSession.Object);
            var expectedCustomer = new Customer { customer_id = 1, customerName = "John", customerEmail = "john@example.com", customerPhone = "123456789", customerPassword = "password" };
            mockSession.Setup(s => s.Get<Customer>(1)).Returns(expectedCustomer);

            // Act
            var result = dao.GetById(1);

            // Assert
            Assert.AreEqual(expectedCustomer, result);
        }

        // Similar tests for other methods...
    }
}