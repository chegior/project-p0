using Xunit;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Testing 
{
    class StoreTests
    {
        public void Test_StoreExist()
        {
            var sut = new Store();
            var actual = sut;
            Assert.IsType<Store>(actual);
            Assert.NotNull(actual);


        }
    }
}