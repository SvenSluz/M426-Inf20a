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
            string actual = fooBarQixDeterminer.Determine(number);

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
            string actual = fooBarQixDeterminer.Determine(number);

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
            string actual = fooBarQixDeterminer.Determine(number);

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
            string actual = fooBarQixDeterminer.Determine(number);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Determine_WhenNumberDivisibleByThreeAndFive_ReturnFooBar()
        {
            //arrange
            int number = 15;
            var fooBarQixDeterminer = new FooBarQixDeterminer();
            var expected = "FooBarBar";
            //act
            string actual = fooBarQixDeterminer.Determine(number);

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
            string actual = fooBarQixDeterminer.Determine(number);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Determine_WhenNumberDivisibleByFiveAndSeven_ReturnBarQix()
        {
            //arrange
            int number = 35;
            var fooBarQixDeterminer = new FooBarQixDeterminer();
            var expected = "BarQixFooBar";
            //act
            string actual = fooBarQixDeterminer.Determine(number);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Determine_WhenNumberDivisibleByThreeFiveAndSeven_ReturnFooBarQix()
        {
            //arrange
            int number = 105;
            var fooBarQixDeterminer = new FooBarQixDeterminer();
            var expected = "FooBarQixBar";
            //act
            var actual = fooBarQixDeterminer.Determine(number);

            //assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Determine_WhenNumberContainsOnlyThree_returnFoo()
        {
            //arrange
            int number = 13;
            var fooBarQixDeterminer = new FooBarQixDeterminer();
            var expected = "Foo";
            //act
            var actual = fooBarQixDeterminer.Determine(number);

            //assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void DetermineByChar_WhenNumberContainsOnlyThree_ReturnFoo()
        {
            //arrange
            int number = 3;
            var fooBarQixDeterminer = new FooBarQixDeterminer();
            var expected = "Foo";
            //act
            var actual = fooBarQixDeterminer.DetermineByChar(number);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DetermineByChar_WhenNumberContainsOnlyFive_ReturnBar()
        {
            //arrange
            int number = 5;
            var fooBarQixDeterminer = new FooBarQixDeterminer();
            var expected = "Bar";
            //act
            var actual = fooBarQixDeterminer.DetermineByChar(number);

            //assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void DetermineByChar_WhenNumberContainsOnlySeven_ReturnQix()
        {
            //arrange
            int number = 7;
            var fooBarQixDeterminer = new FooBarQixDeterminer();
            var expected = "Qix";
            //act
            var actual = fooBarQixDeterminer.DetermineByChar(number);

            //assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void DetermineByChar_WhenNumberContainsTwoSameOfFooBarQixNumbers_ReturnDoubleString()
        {
            //arrange
            int number = 77;
            var fooBarQixDeterminer = new FooBarQixDeterminer();
            var expected = "QixQix";
            //act
            var actual = fooBarQixDeterminer.DetermineByChar(number);

            //assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void DetermineByChar_WhenNumberContainsTwoDifferentOfFooBarQixNumbers_ReturnDoubleStringInOrder()
        {
            //arrange
            int number = 75;
            var fooBarQixDeterminer = new FooBarQixDeterminer();
            var expected = "QixBar";
            //act
            var actual = fooBarQixDeterminer.DetermineByChar(number);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}