int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int currentMax = numbers[numbers.Length - 1];
int[] result = new int[numbers.Length];

result[0] = currentMax;
int resultIndex = 1;

for (int i = numbers.Length - 2; i >= 0; i--)
{
    if (numbers[i] > currentMax)
    {
        currentMax = numbers[i];
        result[resultIndex] = numbers[i];
        resultIndex++;
    }
}

for (int i = resultIndex - 1; i >= 0; i--)
{
    Console.Write($"{result[i]} ");
}