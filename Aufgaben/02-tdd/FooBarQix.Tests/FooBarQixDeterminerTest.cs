using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        [Fact]
        public void Determine_WhenNumberNotDivisible_ReturnNumberAsText()
        {
            //arrange
            int number = 1;
            var fooBarQixDeterminer = new FooBarQixDeterminer();
            var expected = number.ToString();
            //act
            string actual = FooBarQixDeterminer.Determine(number);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Determine_WhenNumberDivisibleByOnlyThree_ReturnFoo()
        {
            //arrange
            int number = 6;
            var fooBarQixDeterminer = new FooBarQixDeterminer();
            var expected = "Foo";
            //act
            string actual = FooBarQixDeterminer.Determine(number);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Determine_WhenNumberDivisibleByOnlyFive_ReturnBar()
        {
            //arrange
            int number = 10;
            var fooBarQixDeterminer = new FooBarQixDeterminer();
            var expected = "Bar";
            //act
            string actual = FooBarQixDeterminer.Determine(number);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Determine_WhenNumberDivisibleByOnlySeven_ReturnBar()
        {
            //arrange
            int number = 14;
            var fooBarQixDeterminer = new FooBarQixDeterminer();
            var expected = "Qix";
            //act
            string actual = FooBarQixDeterminer.Determine(number);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Determine_WhenNumberDivisibleByThreeAndFive_ReturnFooBar()
        {
            //arrange
            int number = 15;
            var fooBarQixDeterminer = new FooBarQixDeterminer();
            var expected = "FooBar";
            //act
            string actual = FooBarQixDeterminer.Determine(number);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Determine_WhenNumberDivisibleByThreeAndSeven_ReturnFooBar()
        {
            //arrange
            int number = 21;
            var fooBarQixDeterminer = new FooBarQixDeterminer();
            var expected = "FooQix";
            //act
            string actual = FooBarQixDeterminer.Determine(number);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Determine_WhenNumberDivisibleByFiveAndSeven_ReturnBarQix()
        {
            //arrange
            int number = 35;
            var fooBarQixDeterminer = new FooBarQixDeterminer();
            var expected = "BarQix";
            //act
            string actual = FooBarQixDeterminer.Determine(number);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Determine_WhenNumberDivisibleByThreeFiveAndSeven_ReturnFooBarQix()
        {
            //arrange
            int number = 105;
            var fooBarQixDeterminer = new FooBarQixDeterminer();
            var expected = "FooBarQix";
            //act
            var actual = FooBarQixDeterminer.Determine(number);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}