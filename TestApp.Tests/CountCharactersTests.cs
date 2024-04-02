using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new List<string>() { "" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new List<string>() { "d" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo("d -> 1"));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new List<string>() { "a", "bc", "bca" };

        // Act
        string result = CountCharacters.Count(input);
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("a -> 2");
        sb.AppendLine("b -> 2");
        sb.Append("c -> 2");

        string expectedResult = sb.ToString();

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new List<string>() { "#a$", "!b%c", "bca" };

        // Act
        string result = CountCharacters.Count(input);
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("# -> 1"); // 1 защото в списъка има един символ #
        sb.AppendLine("a -> 2"); // 2 защото в списъка има два символа а
        sb.AppendLine("$ -> 1");
        sb.AppendLine("! -> 1");
        sb.AppendLine("b -> 2");
        sb.AppendLine("% -> 1");
        sb.Append("c -> 2");

        string expectedResult = sb.ToString();

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
