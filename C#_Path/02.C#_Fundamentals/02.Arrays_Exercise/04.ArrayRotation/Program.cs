int[] numbersArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

int rotations = int.Parse(Console.ReadLine());

for (int i = 0; i < rotations; i++)
{
    int firstEl = numbersArr[0];

	for (int j = 0; j < numbersArr.Length - 1; j++)
	{
        numbersArr[j] = numbersArr[j + 1];
    }

    numbersArr[numbersArr.Length - 1] = firstEl;
}

Console.WriteLine(string.Join(" ", numbersArr));