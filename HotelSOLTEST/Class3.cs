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
    public class RoomDAOImplTests
    {
        [TestMethod]
        public void Insert_Adds_New_Room()
        {
            // Arrange
            var mockSession = new Mock<ISession>();
            var mockTransaction = new Mock<ITransaction>();
            mockSession.Setup(s => s.BeginTransaction()).Returns(mockTransaction.Object);

            var dao = new DAOimpl<Room>(mockSession.Object);
            var roomToInsert = new Room { room_id = 1, roomNumber = 101, type = "Single", roomCapacity = 1, roomSeason = "Summer", price = 100, roomDescription = "Description", booked = false };

            // Act
            dao.Insert(roomToInsert);

            // Assert
            mockSession.Verify(s => s.Save(roomToInsert), Times.Once);
        }

        [TestMethod]
        public void Update_Updates_Room()
        {
            // Arrange
            var mockSession = new Mock<ISession>();
            var dao = new DAOimpl<Room>(mockSession.Object);
            var roomToUpdate = new Room { room_id = 1, roomNumber = 101, type = "Single", roomCapacity = 1, roomSeason = "Summer", price = 100, roomDescription = "Description", booked = false };

            // Act
            dao.Update(roomToUpdate);

            // Assert
            mockSession.Verify(s => s.Update(roomToUpdate), Times.Once);
        }

        [TestMethod]
        public void Delete_Removes_Room()
        {
            // Arrange
            var mockSession = new Mock<ISession>();
            var dao = new DAOimpl<Room>(mockSession.Object);
            var roomToDelete = new Room { room_id = 1, roomNumber = 101, type = "Single", roomCapacity = 1, roomSeason = "Summer", price = 100, roomDescription = "Description", booked = false };

            // Act
            dao.Delete(roomToDelete);

            // Assert
            mockSession.Verify(s => s.Delete(roomToDelete), Times.Once);
        }

        [TestMethod]
        public void GetAll_Returns_All_Rooms()
        {
            // Arrange
            var mockSession = new Mock<ISession>();
            var dao = new DAOimpl<Room>(mockSession.Object);
            var expectedRooms = new List<Room>
            {
                new Room { room_id = 1, roomNumber = 101, type = "Single", roomCapacity = 1, roomSeason = "Summer", price = 100, roomDescription = "Description", booked = false },
                new Room { room_id = 2, roomNumber = 102, type = "Double", roomCapacity = 2, roomSeason = "Summer", price = 150, roomDescription = "Description", booked = false }
            };
            mockSession.Setup(s => s.Query<Room>()).Returns(expectedRooms.AsQueryable());

            // Act
            var result = dao.GetAll();

            // Assert
            CollectionAssert.AreEqual(expectedRooms, result.ToList());
        }
    }
}
