namespace lab5.Models;

public abstract class Sweet
{
    protected Sweet(string name, int weightGrams, decimal sugarGrams)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        if (weightGrams <= 0)
            throw new ArgumentOutOfRangeException(nameof(weightGrams), "Вес должен быть положительным.");
        if (sugarGrams < 0 || sugarGrams > weightGrams)
            throw new ArgumentOutOfRangeException(nameof(sugarGrams), "Сахар должен быть от 0 до веса сладости.");

        Name = name;
        WeightGrams = weightGrams;
        SugarGrams = sugarGrams;
    }

    public string Name { get; }
    public int WeightGrams { get; }
    public decimal SugarGrams { get; }
    public abstract string Description { get; }
}
