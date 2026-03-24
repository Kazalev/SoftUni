int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int sumOfEven = 0;
int sumOfOdd = 0;

foreach (var item in numbers)
{
    if (item % 2 == 0) sumOfEven += item;
    else sumOfOdd += item;
}

Console.WriteLine(sumOfEven - sumOfOdd);