namespace lab5.Models;

public sealed class ChocolateCandy : Candy
{
    public ChocolateCandy(string name, int weightGrams, decimal sugarGrams, string filling)
        : base(name, weightGrams, sugarGrams)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(filling);
        Filling = filling;
    }

    public string Filling { get; }
    public override string Description => $"Шоколадная конфета, начинка: {Filling}";
}
