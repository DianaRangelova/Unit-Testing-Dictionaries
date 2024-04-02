using NUnit.Framework;

using System;
using System.Text;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] plants = Array.Empty<string>();

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] plants = new string[] { "Tulip" };

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Plants with 5 letters:");
        sb.AppendLine("Tulip");
        string expectedResult = sb.ToString().TrimEnd();

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] plants = new string[] { "Tulip", "Rose", "Daisies" };

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Plants with 4 letters:");
        sb.AppendLine("Rose");
        sb.AppendLine("Plants with 5 letters:");
        sb.AppendLine("Tulip");
        sb.AppendLine("Plants with 7 letters:");
        sb.AppendLine("Daisies");
        string expectedResult = sb.ToString().TrimEnd();

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] plants = new string[] { "TuLIp", "ROse", "DaisiES" };

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Plants with 4 letters:");
        sb.AppendLine("ROse");
        sb.AppendLine("Plants with 5 letters:");
        sb.AppendLine("TuLIp");
        sb.AppendLine("Plants with 7 letters:");
        sb.AppendLine("DaisiES");
        string expectedResult = sb.ToString().TrimEnd();

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
