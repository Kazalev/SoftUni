int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fishermen = int.Parse(Console.ReadLine());

double price = 0;

if (season == "Spring") price = 3000;
else if (season == "Summer" || season == "Autumn") price = 4200;
else price = 2600;

if (fishermen <= 6) price = price * 0.9;
else if (fishermen <= 11) price = price * 0.85;
else if (fishermen >= 12) price = price * 0.75;

if (fishermen % 2 == 0 && season != "Autumn") price = price * 0.95;

if (budget >= price)
    Console.WriteLine($"Yes! You have {budget - price:F2} leva left.");
else
    Console.WriteLine($"Not enough money! You need {price - budget:F2} leva.");
