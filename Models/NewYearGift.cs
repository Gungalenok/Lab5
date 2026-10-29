using System.Collections;

namespace lab5.Models;

public sealed class NewYearGift : IEnumerable<Sweet>
{
    private readonly List<Sweet> _sweets = new();

    public NewYearGift(string name)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        Name = name;
    }

    public string Name { get; }
    public int TotalWeightGrams => _sweets.Sum(sweet => sweet.WeightGrams);
    public int Count => _sweets.Count;

    public void Add(Sweet sweet)
    {
        ArgumentNullException.ThrowIfNull(sweet);
        _sweets.Add(sweet);
    }

    public void SortBySugarContent() =>
        _sweets.Sort((first, second) => first.SugarGrams.CompareTo(second.SugarGrams));

    public List<Sweet> FindBySugarContent(decimal minimum, decimal maximum)
    {
        if (minimum < 0 || maximum < minimum)
            throw new ArgumentException("Укажите корректные границы диапазона.");

        return _sweets
            .Where(sweet => sweet.SugarGrams >= minimum && sweet.SugarGrams <= maximum)
            .ToList();
    }

    public IEnumerator<Sweet> GetEnumerator() => _sweets.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
