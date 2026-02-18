string destination = Console.ReadLine();

while (destination != "End")
{
    double minBudget = double.Parse(Console.ReadLine());
    double sum = 0;

    while (minBudget > sum)
    {
        double savedMoney = double.Parse(Console.ReadLine());
        sum += savedMoney;
    }

    Console.WriteLine($"Going to {destination}!");
    destination = Console.ReadLine();
}