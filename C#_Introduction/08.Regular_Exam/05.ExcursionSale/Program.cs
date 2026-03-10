int seaExcursion = int.Parse(Console.ReadLine());
int mountainExcursion = int.Parse(Console.ReadLine());

double seaExcursionPrice = 680;
double mountainExcursionPrice = 499;
double totalPrice = 0;

string package = "";
while ((package = Console.ReadLine()) != "Stop")
{
    if (package == "sea")
    {
        if (seaExcursion == 0) continue;
        totalPrice += seaExcursionPrice;
        seaExcursion--;
    }
    else
    {
        if (mountainExcursion == 0) continue;
        totalPrice += mountainExcursionPrice;
        mountainExcursion--;
    }

    if (seaExcursion == 0 && mountainExcursion == 0)
    {
        Console.WriteLine("Good job! Everything is sold.");
        break;
    }
}

Console.WriteLine($"Profit: {totalPrice} leva.");