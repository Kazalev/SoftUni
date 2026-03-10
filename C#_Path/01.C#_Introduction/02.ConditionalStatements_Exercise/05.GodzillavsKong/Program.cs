double budget = double.Parse(Console.ReadLine());
int statists = int.Parse(Console.ReadLine());
double outfitPerStatist = double.Parse(Console.ReadLine());

double decorPrice = budget * 0.10;
double outfitPrice = statists * outfitPerStatist;
if (statists > 150)
    outfitPrice = outfitPrice - (outfitPrice * 0.10);

double totalBudget = outfitPrice + decorPrice;

if (totalBudget > budget)
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {totalBudget - budget:F2} leva more.");
}
else
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {budget - totalBudget:F2} leva left.");
}
