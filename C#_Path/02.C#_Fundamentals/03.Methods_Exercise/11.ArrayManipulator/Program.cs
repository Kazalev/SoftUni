int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

string command;
while ((command = Console.ReadLine()) != "end")
{
    string[] commandArgs = command.Split();
    string type = "";
    int count = 0;

    switch (commandArgs[0])
    {
        case "exchange":
            int index = int.Parse(commandArgs[1]);
            numbers = ExchangeElements(numbers, index);
            break;
        case "max":
            type = commandArgs[1];
            PrintMaxIndex(numbers, type);
            break;
        case "min":
            type = commandArgs[1];
            PrintMinIndex(numbers, type);
            break;
        case "first":
            type = commandArgs[2];
            count = int.Parse(commandArgs[1]);
            PrintFirstElements(numbers, count, type);
            break;
        case "last":
            type = commandArgs[2];
            count = int.Parse(commandArgs[1]);
            PrintLastElements(numbers, count, type);
            break;
    }
}

Console.WriteLine($"[{string.Join(", ", numbers)}]");

static int[] ExchangeElements(int[] numbers, int index)
{
    if (!IsValidIndex(index, numbers))
    {
        Console.WriteLine("Invalid index");
        return numbers;
    }

    int[] changedArray = new int[numbers.Length];
    int changedArrayIndex = 0;

    for (int i = index + 1; i <= numbers.Length - 1; i++)
    {
        changedArray[changedArrayIndex] = numbers[i];
        changedArrayIndex++;
    }

    for (int i = 0; i <= index; i++)
    {
        changedArray[changedArrayIndex] = numbers[i];
        changedArrayIndex++;
    }

    return changedArray;
}

static void PrintMaxIndex(int[] numbers, string type)
{
    int maxIndex = -1;
    int maxNumber = int.MinValue;

    for (int i = 0; i < numbers.Length; i++)
    {
        int number = numbers[i];

        if (IsOddOrEven(type, number))
        {
            if (number >= maxNumber)
            {
                maxIndex = i;
                maxNumber = number;
            }
        }
    }

    PrintNotDefaultIndex(maxIndex);
}

static void PrintMinIndex(int[] numbers, string type)
{
    int minIndex = -1;
    int minNumber = int.MaxValue;

    for (int i = 0; i < numbers.Length; i++)
    {
        int number = numbers[i];

        if (IsOddOrEven(type, number))
        {
            if (number <= minNumber)
            {
                minIndex = i;
                minNumber = number;
            }
        }
    }

    PrintNotDefaultIndex(minIndex);
}

static void PrintFirstElements(int[] numbers, int count, string type)
{
    if (count > numbers.Length)
    {
        Console.WriteLine("Invalid count");
        return;
    }

    string firstElements = "";
    int elementCount = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        int number = numbers[i];

        if (IsOddOrEven(type, number))
        {
            firstElements += $"{number}, ";
            elementCount++;

            if (elementCount >= count)
            {
                break;
            }
        }
    }

    Console.WriteLine($"[{firstElements.Trim(' ', ',')}]");
}

static void PrintLastElements(int[] numbers, int count, string type)
{
    if (count > numbers.Length)
    {
        Console.WriteLine("Invalid count");
        return;
    }

    string lastElements = "";
    int elementCount = 0;

    for (int i = numbers.Length - 1; i >= 0; i--)
    {
        int number = numbers[i];

        if (IsOddOrEven(type, number))
        {
            lastElements = $"{number}, " + lastElements;
            elementCount++;

            if (elementCount == count)
            {
                break;
            }
        }
    }

    Console.WriteLine($"[{lastElements.Trim(' ', ',')}]");
}


// Helper Methods

static bool IsValidIndex(int index, int[] array)
{
    if (index >= 0 && index <= array.Length - 1) return true;
    else return false;
}

static bool IsOddOrEven(string type, int number)
{
    return type == "even" && number % 2 == 0 || type == "odd" && number % 2 != 0;
}

static void PrintNotDefaultIndex(int index)
{
    if (index == -1) Console.WriteLine("No matches");
    else Console.WriteLine(index);
}