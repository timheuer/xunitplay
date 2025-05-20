namespace PrimeLibrary;

public class Class1
{
    public bool IsAnotherNumber(int foo)
    {
        return foo == 42;
    }

    public bool IsNumber(string foo)
    {
        return int.TryParse(foo, out int parsed);
    }

    public bool IsPrime(int candidate)
    {
        if (candidate < 2)
        {
            return false;
        }

        for (int divisor = 2; divisor <= Math.Sqrt(candidate); ++divisor)
        {
            if (candidate % divisor == 0)
            {
                return false;
            }
        }
        return true;
    }
}
