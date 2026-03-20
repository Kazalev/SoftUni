int number = int.Parse(Console.ReadLine());
int sum = 0;

while (number > 0)
{
    sum += number % 10; // get last digit
    number /= 10;       // remove last digit
}

Console.WriteLine(sum);