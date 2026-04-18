int n = int.Parse(Console.ReadLine());

PrintNxNMatrix(n);

void PrintNxNMatrix(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{n} ");
        }

        Console.WriteLine();
    }
}