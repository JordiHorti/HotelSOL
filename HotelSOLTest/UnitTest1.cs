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
    public class DAOCustomerImplTests
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

        [TestMethod]
        public void Insert_Adds_New_Entity()
        {// Arrange
            var mockSession = new Mock<ISession>();
            var mockTransaction = new Mock<ITransaction>();
            mockSession.Setup(s => s.BeginTransaction()).Returns(mockTransaction.Object);

            var dao = new DAOimpl<Customer>(mockSession.Object);
            var customerToInsert = new Customer { customer_id = 2, customerName = "Jane", customerEmail = "jane@example.com", customerPhone = "987654321", customerPassword = "password" };

            // Act
            dao.Insert(customerToInsert);

            // Assert
            mockSession.Verify(s => s.Save(customerToInsert), Times.Once);

        }

        [TestMethod]
        public void Update_Updates_Entity()
        {
            // Arrange
            var mockSession = new Mock<ISession>();
            var dao = new DAOimpl<Customer>(mockSession.Object);
            var customerToUpdate = new Customer { customer_id = 1, customerName = "UpdatedName", customerEmail = "updated@example.com", customerPhone = "999999999", customerPassword = "updatedpassword" };

            // Act
            dao.Update(customerToUpdate);

            // Assert
            mockSession.Verify(s => s.Update(customerToUpdate), Times.Once);
        }

        [TestMethod]
        public void Delete_Removes_Entity()
        {
            // Arrange
            var mockSession = new Mock<ISession>();
            var dao = new DAOimpl<Customer>(mockSession.Object);
            var customerToDelete = new Customer { customer_id = 1, customerName = "John", customerEmail = "john@example.com", customerPhone = "123456789", customerPassword = "password" };

            // Act
            dao.Delete(customerToDelete);

            // Assert
            mockSession.Verify(s => s.Delete(customerToDelete), Times.Once);
        }

        [TestMethod]
        public void GetAll_Returns_All_Entities()
        {
            // Arrange
            var mockSession = new Mock<ISession>();
            var dao = new DAOimpl<Customer>(mockSession.Object);
            var expectedCustomers = new List<Customer>
            {
                new Customer { customer_id = 1, customerName = "John", customerEmail = "john@example.com", customerPhone = "123456789", customerPassword = "password" },
                new Customer { customer_id = 2, customerName = "Jane", customerEmail = "jane@example.com", customerPhone = "987654321", customerPassword = "password" }
            };
            mockSession.Setup(s => s.Query<Customer>()).Returns(expectedCustomers.AsQueryable());

            // Act
            var result = dao.GetAll();

            // Assert
            Assert.AreEqual(expectedCustomers.Count, result.Count);
            for (int i = 0; i < expectedCustomers.Count; i++)
            {
                Assert.AreEqual(expectedCustomers[i], result[i]);
            }

        }

        // Similar tests for other methods...
    }
}
