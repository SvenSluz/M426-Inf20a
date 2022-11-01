using System;
using System.Collections.Generic;

namespace Statistics;

public class Median
{
    public double CalculateMedian(List<double> numbers)
    {
        if (numbers.Count==0)
        {
            throw new ArgumentException();
        }
        numbers.Sort();
        var middle = numbers.Count / 2;
        return numbers.Count % 2 == 0 ? (numbers[middle] + numbers[middle - 1]) / 2 : numbers[middle];
    }
}