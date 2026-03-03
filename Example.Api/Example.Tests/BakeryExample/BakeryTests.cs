using NSubstitute;
using Shouldly;

namespace Example.Tests.BakeryExample;

using static Flavor; // To simplify the code for demonstration.

public class BakeryTests
{
    [Fact]
    public void Ordering_a_cupcake_when_affordable_returns_the_cupcake()
    {
        // Arrange
        var flavor = Chocolate;
        var cost = 15;
        var customerBalance = 30;
        var expectedCupcake = new Cupcake(flavor, cost);
        
        var stock = Substitute.For<IBakeryRepository>();
        stock.GetCupcake(Chocolate).Returns(expectedCupcake);
        
        var bakery = new Bakery(stock);
        
        // Act
        var actualCupcake = bakery.Order(flavor, customerBalance);
        
        // Assert
        actualCupcake.ShouldNotBeNull();
        actualCupcake.Flavor.ShouldBe(Chocolate);
    }
}