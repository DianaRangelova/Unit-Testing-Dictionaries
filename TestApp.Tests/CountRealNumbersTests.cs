using NUnit.Framework;

using System;
using System.Text;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] input = Array.Empty<int>();

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 35 };

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo("35 -> 1"));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 1, 1, 2, 2, 2, 5, 5, 5, 5 };

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo("1 -> 2" + Environment.NewLine +
                                       "2 -> 3" + Environment.NewLine +
                                       "5 -> 4"));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { -1, -1, -2, -2, -2, -5, -5, -5, -5 };

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo("-5 -> 4" + Environment.NewLine +
                                       "-2 -> 3" + Environment.NewLine +
                                       "-1 -> 2"));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        int[] input = new int[] { 0, 0, 0 };

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo("0 -> 3"));
    }

    [Test]
    public void Test_Count_WithMixedPositiveAndNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { -1, 1, -2, -2, 2, 3, 3, -3, -3 };

        // Act
        string result = CountRealNumbers.Count(input);
        // Assert

        Assert.That(result, Is.EqualTo("-3 -> 2" + Environment.NewLine +
                                       "-2 -> 2" + Environment.NewLine +
                                       "-1 -> 1" + Environment.NewLine +
                                       "1 -> 1" + Environment.NewLine +
                                       "2 -> 1" + Environment.NewLine +
                                       "3 -> 2"));
    }
}


