int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    int sum = 0;
    int currentNumber = i;

    while (currentNumber > 0)
    {
        sum += currentNumber % 10;
        currentNumber /= 10;
    }

    bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
    Console.WriteLine($"{i} -> {isSpecial}");
}