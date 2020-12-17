using Xunit;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Testing 
{
 public class PizzaTests
 {

     private void Test_PizzaExists(){
         var sut = new Pizza();
         var actual = sut;
         Assert.IsType<Pizza>(actual);
         Assert.NotNull(actual);
         
     }
     
 }
}