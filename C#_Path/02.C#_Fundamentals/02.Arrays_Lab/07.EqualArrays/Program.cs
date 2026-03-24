int[] firstArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] secondArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

int indexDiff = -1;
int sum = 0;

for (int i = 0; i < firstArr.Length; i++)
{
    if (firstArr[i] != secondArr[i])
    {
        indexDiff = i;
        break;
    }
    else sum += firstArr[i];
}

if (indexDiff > -1) Console.WriteLine($"Arrays are not identical. Found difference at {indexDiff} index");
else Console.WriteLine($"Arrays are identical. Sum: {sum}");