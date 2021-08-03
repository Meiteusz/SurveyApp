using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Models.Entities.Interfaces;
using NSubstitute;

namespace Controllers.Tests
{
    [TestClass]
    public class UserTests
    {
        private readonly IUserBLL _UserBLL;
        private readonly IUser _User = Substitute.For<IUser>();

        public UserTests()
        {
            _UserBLL = new UserBLL(_User);
        }

        [TestMethod]
        public void LoginUser_ShouldReturnSuccess_WhenSuccessTrue()
        {
            // Arrange
            var Login = "TestLogin";
            var Password = "TestPass";
            var User = _UserBLL.Create(Login, Password);
            var DataUser = new ResponseData<User> { Success = true, GetData = User };
            _UserBLL.LoginUser(User).Returns(DataUser);


            // Act
            var UserReturned = _UserBLL.LoginUser(User);


            // Assert
            Assert.IsTrue(UserReturned.Success);
        }


        [TestMethod]
        public void Create_ShouldReturnNotNull_WhenUserCreated()
        {
            // Arrange
            IUser User;

            // Act
            User = _UserBLL.Create();

            // Assert
            Assert.IsNotNull(User);
        }
    }
}
