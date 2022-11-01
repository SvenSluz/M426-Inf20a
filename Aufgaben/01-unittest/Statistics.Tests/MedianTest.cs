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
        var numbers = new List<double> {1, 2, 3, 4, 5};
        var expected = 3.0;
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
        var numbers = new List<double> {1, 2, 4, 5};
        var expected = 3.0;
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
        Assert.Throws<ArgumentException>(()=>median.CalculateMedian(numbers));
    }
}