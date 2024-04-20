using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using HotelSOL.DAO;
using HotelSOL.Models;

namespace HotelSOLTEST
{
    [TestClass]
    public class InvoiceDAOImplTests
    {
        [TestMethod]
        public void Insert_Adds_New_Invoice()
        {
            // Arrange
            var mockSession = new Mock<ISession>();
            var mockTransaction = new Mock<ITransaction>();
            mockSession.Setup(s => s.BeginTransaction()).Returns(mockTransaction.Object);

            var dao = new DAOimpl<Invoice>(mockSession.Object);
            var invoiceToInsert = new Invoice { invoices_id = 1, bookings_id = 1, customer_id = 1, customerName = "John", customerEmail = "john@example.com", customerPhone = "123456789", roomNumber = 101, roomType = "Single", roomCapacity = 1, roomPrice = 100, service = "Room Service", servicePrice = 20, checkIn = DateTime.Now, checkOut = DateTime.Now.AddDays(1), days = 1, totalPrice = 120 };

            // Act
            dao.Insert(invoiceToInsert);

            // Assert
            mockSession.Verify(s => s.Save(invoiceToInsert), Times.Once);
        }

        [TestMethod]
        public void Update_Updates_Invoice()
        {
            // Arrange
            var mockSession = new Mock<ISession>();
            var dao = new DAOimpl<Invoice>(mockSession.Object);
            var invoiceToUpdate = new Invoice { invoices_id = 1, bookings_id = 1, customer_id = 1, customerName = "John", customerEmail = "john@example.com", customerPhone = "123456789", roomNumber = 101, roomType = "Single", roomCapacity = 1, roomPrice = 100, service = "Room Service", servicePrice = 20, checkIn = DateTime.Now, checkOut = DateTime.Now.AddDays(1), days = 1, totalPrice = 120 };

            // Act
            dao.Update(invoiceToUpdate);

            // Assert
            mockSession.Verify(s => s.Update(invoiceToUpdate), Times.Once);
        }

        [TestMethod]
        public void Delete_Removes_Invoice()
        {
            // Arrange
            var mockSession = new Mock<ISession>();
            var dao = new DAOimpl<Invoice>(mockSession.Object);
            var invoiceToDelete = new Invoice { invoices_id = 1, bookings_id = 1, customer_id = 1, customerName = "John", customerEmail = "john@example.com", customerPhone = "123456789", roomNumber = 101, roomType = "Single", roomCapacity = 1, roomPrice = 100, service = "Room Service", servicePrice = 20, checkIn = DateTime.Now, checkOut = DateTime.Now.AddDays(1), days = 1, totalPrice = 120 };

            // Act
            dao.Delete(invoiceToDelete);

            // Assert
            mockSession.Verify(s => s.Delete(invoiceToDelete), Times.Once);
        }

        [TestMethod]
        public void GetAll_Returns_All_Invoices()
        {
            // Arrange
            var mockSession = new Mock<ISession>();
            var dao = new DAOimpl<Invoice>(mockSession.Object);
            var expectedInvoices = new List<Invoice>
            {
                new Invoice { invoices_id = 1, bookings_id = 1, customer_id = 1, customerName = "John", customerEmail = "john@example.com", customerPhone = "123456789", roomNumber = 101, roomType = "Single", roomCapacity = 1, roomPrice = 100, service = "Room Service", servicePrice = 20, checkIn = DateTime.Now, checkOut = DateTime.Now.AddDays(1), days = 1, totalPrice = 120 },
                new Invoice { invoices_id = 2, bookings_id = 2, customer_id = 2, customerName = "Jane", customerEmail = "jane@example.com", customerPhone = "987654321", roomNumber = 102, roomType = "Double", roomCapacity = 2, roomPrice = 150, service = "Room Service", servicePrice = 20, checkIn = DateTime.Now, checkOut = DateTime.Now.AddDays(2), days = 2, totalPrice = 190 }
            };
            mockSession.Setup(s => s.Query<Invoice>()).Returns(expectedInvoices.AsQueryable());

            // Act
            var result = dao.GetAll();

            // Assert
            CollectionAssert.AreEqual(expectedInvoices, result.ToList());
        }
    }
}
