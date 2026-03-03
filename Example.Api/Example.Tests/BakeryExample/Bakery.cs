namespace Example.Tests.BakeryExample;

public class Bakery(IBakeryRepository repository)
{
    public Cupcake? Order(Flavor flavor, int customerBalance)
    {
        var cupcake = repository.GetCupcake(flavor);

        return cupcake.Cost <= customerBalance ? cupcake : null;
    }
}