using PizzaBox.Domain.Models;
using Xunit;


namespace PizzaBox.Testing.Testing
{
    public class StoreTests
    {
        [Fact]
        public void Test_BostonStore_Fact()
        {
            // arrange
            var sut = new BostonStore();
            var expected = "Boston Store";

            // act
            var actual = sut.Name;

            // assert
            Assert.Equal(expected, actual);
        }


        // [Theory]
        // [InlineData("Boston Store")]
        // [InlineData("")]
        // public void Test_BostonStore_Theory(string expected)
        // {
        //     // arrange
        //     var sut = new BostonStore();
        //     var expected = "Boston Store";

        //     // act
        //     var actual = sut.Name;

        //     // assert
        //     Assert.Equal(expected, actual);
        // }        



    }
}