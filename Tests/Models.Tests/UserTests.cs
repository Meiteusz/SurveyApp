using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Entities.Interfaces;
using NSubstitute;

namespace Models.Tests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void LoginUser_LoginUserIntoSystem_ReturnsSuccessTrue()
        {
            var mockUser = Substitute.For<IUser>();
            
        }
    }
}
