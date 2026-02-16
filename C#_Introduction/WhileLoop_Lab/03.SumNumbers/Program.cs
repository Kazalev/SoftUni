int number = int.Parse(Console.ReadLine());
int input = 0;
int sum = 0;

while (sum < number)
{
    input = int.Parse(Console.ReadLine());
    sum += input;
}

Console.WriteLine(sum);