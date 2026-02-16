string input = Console.ReadLine();

int min = int.MaxValue;

while (input != "Stop")
{
    int number = int.Parse(input);

    if (number < min) min = number;

    input = Console.ReadLine();
}

Console.WriteLine(min);