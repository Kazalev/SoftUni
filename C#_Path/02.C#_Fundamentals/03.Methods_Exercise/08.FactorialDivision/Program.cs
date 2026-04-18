int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());

Console.WriteLine($"{(Factorial(first) / Factorial(second)):f2}");

static double Factorial(long number)
{
    double result = number;

    for (long i = number - 1; i >= 1; i--)
    {
        result *= i;
    }

    return result;
}