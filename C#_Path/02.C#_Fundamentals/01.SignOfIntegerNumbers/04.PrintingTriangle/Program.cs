int count = int.Parse(Console.ReadLine());
PrintTriangle(count);

static void PrintTriangle(int count)
{
    for (int i = 1; i <= count; i++)
        PrintLine(1, i);

    for (int i = count - 1; i >= 0; i--)
        PrintLine(1, i);
}

static void PrintLine(int start, int end)
{
    for (int i = start; i <= end; i++)
        Console.Write(i + " ");

    Console.WriteLine();
}