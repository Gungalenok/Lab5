using lab5.Models;

var gift = new NewYearGift("Новогодний подарок");
gift.Add(new ChocolateCandy("Мишка", 18, 9, "вафельная"));
gift.Add(new ChocolateCandy("Трюфель", 15, 6, "шоколадная"));
gift.Add(new CaramelCandy("Звёздочка", 12, 10, "клубничная"));
gift.Add(new CaramelCandy("Снежинка", 10, 8, "мятная"));
gift.Add(new Marshmallow("Зефир ванильный", 25, 12, "ванильный"));
gift.Add(new Marshmallow("Зефир яблочный", 22, 9, "яблочный"));

Console.WriteLine($"{gift.Name}: сладостей — {gift.Count}, общий вес — {gift.TotalWeightGrams} г.");
Console.WriteLine("\nСостав подарка:");
PrintSweets(gift);

gift.SortBySugarContent();
Console.WriteLine("Сладости по возрастанию содержания сахара:");
PrintSweets(gift);

Console.WriteLine("Сладости с содержанием сахара от 8 до 10 г:");
PrintSweets(gift.FindBySugarContent(8, 10));

static void PrintSweets(IEnumerable<Sweet> sweets)
{
    foreach (var sweet in sweets)
        Console.WriteLine($"{sweet.Name}: {sweet.Description}; вес {sweet.WeightGrams} г; сахар {sweet.SugarGrams} г");
    Console.WriteLine();
}
