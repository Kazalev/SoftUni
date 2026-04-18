int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

PrintSmallestNumber(a, b, c);

static void PrintSmallestNumber(int a, int b, int c)
{
    int smallest = a;

    if (b < smallest) smallest = b;
    if (c < smallest) smallest = c;

    Console.WriteLine(smallest);
}