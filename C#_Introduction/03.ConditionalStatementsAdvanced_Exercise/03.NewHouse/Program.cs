string flower = Console.ReadLine();
int count = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

double pricePerFlower = 0;

if (flower == "Roses") pricePerFlower = 5;
else if (flower == "Dahlias") pricePerFlower = 3.80;
else if (flower == "Tulips") pricePerFlower = 2.80;
else if (flower == "Narcissus") pricePerFlower = 3;
else if (flower == "Gladiolus") pricePerFlower = 2.50;

double total = pricePerFlower * count;

if (flower == "Roses" && count > 80) total = total * 0.9;
else if (flower == "Dahlias" && count > 90) total = total * 0.85;
else if (flower == "Tulips" && count > 80) total = total * 0.85;
else if (flower == "Narcissus" && count < 120) total = total * 1.15;
else if (flower == "Gladiolus" && count < 80) total = total * 1.2;

if (budget >= total)
    Console.WriteLine($"Hey, you have a great garden with {count} {flower} and {budget - total:F2} leva left.");
else
    Console.WriteLine($"Not enough money, you need {total - budget:F2} leva more.");
