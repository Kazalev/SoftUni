string[] items = Console.ReadLine().Split(" ").ToArray();

for (int i = 0; i < items.Length / 2; i++)
{
    string temp = items[i];
    items[i] = items[items.Length - 1 - i];
    items[items.Length - 1 - i] = temp;
}

Console.WriteLine(string.Join(" ", items));