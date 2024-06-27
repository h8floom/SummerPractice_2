namespace lol_kek.practice_3;

public class Multiplier
{
    public virtual double Calculate(int a, int b)
    {
        return a * b;
    }
}

public class AdvancedCalculator : Multiplier
{
    public override double Calculate(int a, int b)
    {
        return Math.Sqrt(a + b);
    }
}
