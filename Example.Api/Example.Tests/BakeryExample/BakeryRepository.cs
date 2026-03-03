namespace Example.Tests.BakeryExample;

public class BakeryRepository : IBakeryRepository
{
    public Cupcake GetCupcake(Flavor flavor)
    {
        return flavor switch
        {
            Flavor.Vanilla => new Cupcake(Flavor.Vanilla, 10),
            Flavor.Chocolate => new Cupcake(Flavor.Chocolate, 15),
            _ => throw new ArgumentOutOfRangeException(nameof(flavor), $"Unexpected flavor: {flavor}"),
        };
    }
}