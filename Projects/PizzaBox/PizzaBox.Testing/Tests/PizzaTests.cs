using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
    public class PizzaTests
    {
//         [Fact]
//         public void Test_PepperoniPizzaMinToppings_Fact()
//         {
//             var sut = new PepperoniPizza();
//             var expected = 2;
//          //   var maxTopping = 5;
//          //   var expected = "Pepperoni Pizza";

//          //   var minActual = sut.Toppings.Count;
//             var actual = sut.Toppings.Count;
// //            var actual = "Pepperoni Pizza";

//             Assert.Equal(expected, actual);
//         }

        

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(5)]
        [InlineData(6)]
        public void Test_PepperoniPizzaToppingsCount_Fact(int value)
        {
            var sut = new PepperoniPizza();
            var result = sut.ValidateToppingRange(value);
            Assert.True(result, $"{value} is not within range.");
        }

    }
}