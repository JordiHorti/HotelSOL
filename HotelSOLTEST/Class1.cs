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
    public class UserDAOImplTests
    {
        [TestMethod]
        public void Insert_Adds_New_User()
        {
            // Arrange
            var mockSession = new Mock<ISession>();
            var mockTransaction = new Mock<ITransaction>();
            mockSession.Setup(s => s.BeginTransaction()).Returns(mockTransaction.Object);

            var dao = new DAOimpl<User>(mockSession.Object);
            var userToInsert = new User { user_id = 1, userName = "John", userEmail = "john@example.com", userPassword = "password", user_role = 1 };

            // Act
            dao.Insert(userToInsert);

            // Assert
            mockSession.Verify(s => s.Save(userToInsert), Times.Once);
        }

        [TestMethod]
        public void Update_Updates_User()
        {
            // Arrange
            var mockSession = new Mock<ISession>();
            var dao = new DAOimpl<User>(mockSession.Object);
            var userToUpdate = new User { user_id = 1, userName = "UpdatedName", userEmail = "updated@example.com", userPassword = "updatedpassword", user_role = 2 };

            // Act
            dao.Update(userToUpdate);

            // Assert
            mockSession.Verify(s => s.Update(userToUpdate), Times.Once);
        }

        [TestMethod]
        public void Delete_Removes_User()
        {
            // Arrange
            var mockSession = new Mock<ISession>();
            var dao = new DAOimpl<User>(mockSession.Object);
            var userToDelete = new User { user_id = 1, userName = "John", userEmail = "john@example.com", userPassword = "password", user_role = 1 };

            // Act
            dao.Delete(userToDelete);

            // Assert
            mockSession.Verify(s => s.Delete(userToDelete), Times.Once);
        }

        [TestMethod]
        public void GetAll_Returns_All_Users()
        {
            // Arrange
            var mockSession = new Mock<ISession>();
            var dao = new DAOimpl<User>(mockSession.Object);
            var expectedUsers = new List<User>
            {
                new User { user_id = 1, userName = "John", userEmail = "john@example.com", userPassword = "password", user_role = 1 },
                new User { user_id = 2, userName = "Jane", userEmail = "jane@example.com", userPassword = "password", user_role = 1 }
            };
            mockSession.Setup(s => s.Query<User>()).Returns(expectedUsers.AsQueryable());

            // Act
            var result = dao.GetAll();

            // Assert
            CollectionAssert.AreEqual(expectedUsers, result.ToList());
        }
    }
}
