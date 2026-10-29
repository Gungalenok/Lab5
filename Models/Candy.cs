namespace lab5.Models;

public abstract class Candy : Sweet
{
    protected Candy(string name, int weightGrams, decimal sugarGrams)
        : base(name, weightGrams, sugarGrams) { }
}