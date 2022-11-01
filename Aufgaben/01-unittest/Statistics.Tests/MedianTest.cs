using System;
using System.Collections.Generic;
using Xunit;

namespace Statistics.Tests;

public class MedianTest
{
    [Fact]
    public void TestMedianForOddNumberOfElements()
    {
        //given
        var numbers = new List<double> {5, 3, 2, 4, 1, 7, 6};
        var expected = 4.0;
        var median = new Median();
        //when
        var actual = median.CalculateMedian(numbers);
        //then
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestMedianForEvenNumberOfElements()
    {
        //given
        var numbers = new List<double> {4, 5, 1, 5, 6, 2};
        var expected = 4.5;
        var median = new Median();
        //when
        var actual = median.CalculateMedian(numbers);
        //then
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestMedianForNoElements()
    {
        //given
        var numbers = new List<double>();
        var median = new Median();
        //when
        //then
        Assert.Throws<ArgumentException>(() => median.CalculateMedian(numbers));
    }
}