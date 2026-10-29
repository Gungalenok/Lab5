namespace lab5.Models;

public sealed class Marshmallow : Sweet
{
    public Marshmallow(string name, int weightGrams, decimal sugarGrams, string variety)
        : base(name, weightGrams, sugarGrams)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(variety);
        Variety = variety;
    }

    public string Variety { get; }
    public override string Description => $"Зефир, сорт: {Variety}";
}
