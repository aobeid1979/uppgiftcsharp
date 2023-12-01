using Moq;

using NUnit;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace IDatabase
{
    [TestFixture]
    internal class UserManagerTests
    {
        [Test]
        public void AddUser_ValidUser_CallsAddUserInDatabase()
        {
            // Arrange
            var databaseMock = new Mock<IDatabase>();
            var userManager = new UserManager(databaseMock.Object);
            var user = new User { UserId = 1, UserName = "TestUser" };

            // Act
            userManager.AddUser(user);

            // Assert
            databaseMock.Verify(d => d.AddUser(user), Times.Once);
        }

        [Test]
        public void RemoveUser_ValidUserId_CallsRemoveUserInDatabase()
        {
            // Arrange
            var databaseMock = new Mock<IDatabase>();
            var userManager = new UserManager(databaseMock.Object);
            var userId = 1;

            // Act
            userManager.RemoveUser(userId);

            // Assert
            databaseMock.Verify(d => d.RemoveUser(userId), Times.Once);
        }
    }
}
