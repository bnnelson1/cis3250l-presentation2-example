namespace Example.Tests.BakeryExample;

public enum Flavor
{
    Vanilla,
    Chocolate
}

public record Cupcake(Flavor Flavor, int Cost);
