using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using HotelSOL.DAO;
using HotelSOL.Models;
using HotelSOL.Forms;

namespace HotelSOLTEST
{
    [TestClass]
    public class ServiceFormTests
    {
        [TestMethod]
        public void Insert_Adds_New_Service()
        {
            // Arrange
            var mockSession = new Mock<ISession>();
            var mockTransaction = new Mock<ITransaction>();
            mockSession.Setup(s => s.BeginTransaction()).Returns(mockTransaction.Object);

            var dao = new DAOimpl<Service>(mockSession.Object);
            var serviceToInsert = new Service { services_id = 1, service = "Room Cleaning", servicePrice = 50 };

            // Act
            dao.Insert(serviceToInsert);

            // Assert
            mockSession.Verify(s => s.Save(serviceToInsert), Times.Once);
        }

        [TestMethod]
        public void Update_Updates_Service()
        {
            // Arrange
            var mockSession = new Mock<ISession>();
            var dao = new DAOimpl<Service>(mockSession.Object);
            var serviceToUpdate = new Service { services_id = 1, service = "Room Cleaning", servicePrice = 50 };

            // Act
            dao.Update(serviceToUpdate);

            // Assert
            mockSession.Verify(s => s.Update(serviceToUpdate), Times.Once);
        }

        [TestMethod]
        public void Delete_Removes_Service()
        {
            // Arrange
            var mockSession = new Mock<ISession>();
            var dao = new DAOimpl<Service>(mockSession.Object);
            var serviceToDelete = new Service { services_id = 1, service = "Room Cleaning", servicePrice = 50 };

            // Act
            dao.Delete(serviceToDelete);

            // Assert
            mockSession.Verify(s => s.Delete(serviceToDelete), Times.Once);
        }

        [TestMethod]
        public void GetAll_Returns_All_Services()
        {
            // Arrange
            var mockSession = new Mock<ISession>();
            var dao = new DAOimpl<Service>(mockSession.Object);
            var expectedServices = new List<Service>
            {
                new Service { services_id = 1, service = "Room Cleaning", servicePrice = 50 },
                new Service { services_id = 2, service = "Laundry", servicePrice = 30 }
            };
            mockSession.Setup(s => s.Query<Service>()).Returns(expectedServices.AsQueryable());

            // Act
            var result = dao.GetAll();

            // Assert
            CollectionAssert.AreEqual(expectedServices, result.ToList());
        }
    }
}
