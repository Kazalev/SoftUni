int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int currentSequenceLength = 1;
int currentSequenceStartIndex = 0;

int longestSequenceLength = 1;
int longestSequenceStartIndex = 0;

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] == numbers[i - 1]) currentSequenceLength++;
    else
    {
        currentSequenceLength = 1;
        currentSequenceStartIndex = i;
    }

    if (currentSequenceLength > longestSequenceLength)
    {
        longestSequenceLength = currentSequenceLength;
        longestSequenceStartIndex = currentSequenceStartIndex;
    }
}

for (int i = longestSequenceStartIndex; i < longestSequenceStartIndex + longestSequenceLength; i++)
{
    Console.Write(numbers[i] + " ");
}