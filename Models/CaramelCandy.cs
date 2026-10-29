namespace lab5.Models;

public sealed class CaramelCandy : Candy
{
    public CaramelCandy(string name, int weightGrams, decimal sugarGrams, string flavor)
        : base(name, weightGrams, sugarGrams)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(flavor);
        Flavor = flavor;
    }

    public string Flavor { get; }
    public override string Description => $"Карамельная конфета, вкус: {Flavor}";
}
