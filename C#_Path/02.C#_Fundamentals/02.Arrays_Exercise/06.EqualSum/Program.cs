int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int resultIndex = -1;

for (int i = 0; i < numbers.Length; i++)
{
    int leftSum = 0;
    int rightSum = 0;
    int currentNumber = numbers[i];

    for (int j = i + 1; j < numbers.Length; j++)
    {
        rightSum += numbers[j];
    }

    for (int k = i - 1; k >= 0; k--)
    {
        leftSum += numbers[k];
    }

    if (leftSum == rightSum)
    {
        resultIndex = i;
        break;
    }
}

if (resultIndex > -1) Console.WriteLine(resultIndex);
else Console.WriteLine("no");