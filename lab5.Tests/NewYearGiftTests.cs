using lab5.Models;

namespace lab5.Tests;

public class NewYearGiftTests
{
    [Fact]
    public void TotalWeightGrams_ReturnsSumOfAllSweets()
    {
        var gift = CreateGift();
        Assert.Equal(45, gift.TotalWeightGrams);
    }

    [Fact]
    public void SortBySugarContent_OrdersSweetsFromLowestToHighest()
    {
        var gift = CreateGift();
        gift.SortBySugarContent();
        Assert.Equal(new[] { "Карамель", "Зефир", "Шоколад" }, gift.Select(sweet => sweet.Name));
    }

    [Fact]
    public void FindBySugarContent_IncludesBothRangeBoundaries()
    {
        var gift = CreateGift();
        var result = gift.FindBySugarContent(5, 10);
        Assert.Equal(new[] { "Шоколад", "Карамель", "Зефир" }, result.Select(sweet => sweet.Name));
    }

    [Fact]
    public void FindBySugarContent_ReturnsEmptyListWhenNoSweetMatches()
    {
        var gift = CreateGift();
        Assert.Empty(gift.FindBySugarContent(11, 15));
    }

    [Theory]
    [InlineData(-1, 5)]
    [InlineData(8, 4)]
    public void FindBySugarContent_RejectsInvalidRange(decimal minimum, decimal maximum)
    {
        var gift = CreateGift();
        Assert.Throws<ArgumentException>(() => gift.FindBySugarContent(minimum, maximum));
    }

    [Fact]
    public void Add_RejectsNullSweet()
    {
        var gift = new NewYearGift("Подарок");
        Assert.Throws<ArgumentNullException>(() => gift.Add(null!));
    }

    private static NewYearGift CreateGift()
    {
        var gift = new NewYearGift("Тестовый подарок");
        gift.Add(new ChocolateCandy("Шоколад", 20, 10, "ореховая"));
        gift.Add(new CaramelCandy("Карамель", 10, 5, "мятная"));
        gift.Add(new Marshmallow("Зефир", 15, 8, "ванильный"));
        return gift;
    }
}


