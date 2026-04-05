string type = Console.ReadLine();

if (type == "int")
{
    int first = int.Parse(Console.ReadLine());
    int second = int.Parse(Console.ReadLine());

    Console.WriteLine(GetMaxInt(first, second));
}
else if (type == "char")
{
    char first = char.Parse(Console.ReadLine());
    char second = char.Parse(Console.ReadLine());

    Console.WriteLine(GetMaxChar(first, second));
}
else
{
    string first = Console.ReadLine();
    string second = Console.ReadLine();

    Console.WriteLine(GetMaxString(first, second));
}

static int GetMaxInt(int first, int second)
{
    if (first > second)
    {
        return first;
    }
    return second;
}

static char GetMaxChar(char first, char second)
{
    if (first > second)
    {
        return first;
    }
    return second;
}

static string GetMaxString(string first, string second)
{
    if (first.CompareTo(second) == 1)
    {
        return first;
    }
    return second;
}