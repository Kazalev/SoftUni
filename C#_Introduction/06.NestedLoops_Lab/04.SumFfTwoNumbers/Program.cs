int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());
int magicNumber = int.Parse(Console.ReadLine());

bool isCombinationFound = false;
int combinations = 0;

for (int x1 = start; x1 <= end; x1++)
{
    for (int x2 = start; x2 <= end; x2++)
    {
        int sum = x1 + x2;
        combinations++;

        if (sum == magicNumber)
        {
            Console.WriteLine($"Combination N:{combinations} ({x1} + {x2} = {magicNumber})");
            isCombinationFound = true;
            break;

        }
    }

    if (isCombinationFound) break;
}

if (isCombinationFound == false) Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");