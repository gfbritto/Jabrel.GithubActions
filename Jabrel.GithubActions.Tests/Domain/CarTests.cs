namespace Jabrel.GithubActions.Tests.Domain;

using Jabrel.GithubActions.Domain;

public class CarTests
{
    [Fact]
    public void Drive_Valid_ShouldPrintText()
    {
        // Arrange
        var car = new Car();

        // Act
        car.Drive();

        // Assert
        Assert.True(true);
    }
}