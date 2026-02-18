int input = int.Parse(Console.ReadLine());

int combinations = 0;

for (int x1 = 0; x1 <= input; x1++)
{
    for (int x2 = 0; x2 <= input; x2++)
    {
        for (int x3 = 0; x3 <= input; x3++)
        {
            int sum = x1 + x2 + x3;
            if (sum == input) combinations++;
        }
    }
}

Console.WriteLine(combinations);