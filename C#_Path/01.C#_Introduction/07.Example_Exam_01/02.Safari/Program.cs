double budget = double.Parse(Console.ReadLine());
int nights = int.Parse(Console.ReadLine());
double pricePerNight = double.Parse(Console.ReadLine());
int percentExtra = int.Parse(Console.ReadLine());

if (nights > 7) pricePerNight *= 0.95;

double totalForNights = nights * pricePerNight;
double extraExpenses = (budget * percentExtra) / 100.00;

double totalNeeded = totalForNights + extraExpenses;

if (budget >= totalNeeded) Console.WriteLine($"Ivanovi will be left with {budget - totalNeeded:F2} leva after vacation.");
else Console.WriteLine($"{totalNeeded - budget:F2} leva needed.");