using Xunit;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Testing 
{
    class UserTests
    {
        public void Test_UserExist()
        {
            var sut = new UserTests(); // Subject Under Test
            var actual = sut;
            Assert.IsType<User>(actual);
            Assert.NotNull(actual);
        }
    }
}