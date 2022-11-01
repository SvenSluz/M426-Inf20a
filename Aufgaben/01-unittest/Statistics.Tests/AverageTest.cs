using System;
using System.Collections.Generic;
using Xunit;

namespace Statistics.Tests
{
    public class AverageTest
    {
        [Fact]
        public void TestMeanOfTwoNumbers()
        {
            List<int> numbers = new List<int> {10, 20};
            double expected = 15;
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMeanOfFiveNumbers()
        {
            List<int> numbers = new List<int> {5, 10, 15, 20, 25};
            double expected = 15;
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }
    }
}