int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int sum = 0;

foreach(var item in numbers)
{
    if (item % 2 == 0) sum += item;
}

Console.WriteLine(sum);