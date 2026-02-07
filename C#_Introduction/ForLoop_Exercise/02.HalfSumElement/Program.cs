int n = int.Parse(Console.ReadLine());
int sum = 0;
int max = 0;

for (int i = 1; i <= n; i++)
{
    int num = int.Parse(Console.ReadLine());
    sum = sum + num;

    if (num > max) max = num;
}

int sumWithoutMax = sum - max;

if (max == sumWithoutMax)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {max}");

}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(max - sumWithoutMax)}");
}

