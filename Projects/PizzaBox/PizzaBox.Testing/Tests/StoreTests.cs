using PizzaBox.Domain.Models;
using Xunit;


namespace PizzaBox.Testing.Testing
{
    public class StoreTests
    {
        [Fact]
        public void Test_SantaFeStore_Fact()
        {
            // arrange
            var sut = new SantaFeStore();
            var expected = "Santa Fe Store";

            // act
            var actual = sut.Name;

            // assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("Santa Fe Store")]
        [InlineData("")]
        public void Test_SantaFe_Theory(string expected)
        {
            // arrange
            var sut = new SantaFeStore();

            // act
            var actual = sut.Name;

            // assert
            Assert.Equal(expected, actual);
        }        



    }
}