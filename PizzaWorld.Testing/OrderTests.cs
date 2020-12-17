using PizzaWorld.Domain.Models; // This is actualing where can find the PROJECT 
using Xunit;

namespace PizzaWorld.Testing 
{
    //enforcement of a correct answer with the ATTRIBUTE below
    public class OrderTests
    {
        //enforcement of a correct answer with the ATTRIBUTE below
         [Fact]
         private void Test_OrderExists()
         {
             //arrange
            var sut = new Order(); //var  does an inferece
            // Order sut = new Order(); -> this is an statement
             //act
            var actual = sut;
             //assert
             Assert.IsType<Order>(actual);
             Assert.NotNull(actual);

         }
    }
}