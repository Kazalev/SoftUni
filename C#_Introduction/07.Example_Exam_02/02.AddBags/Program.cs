double luggagePriceAboveTwentyKgs = double.Parse(Console.ReadLine());
double luggageKgs = double.Parse(Console.ReadLine());
int daysUntilTravel = int.Parse(Console.ReadLine());
int luggageCount = int.Parse(Console.ReadLine());

double luggageTaxes = 0;

if (luggageKgs < 10) luggageTaxes = luggagePriceAboveTwentyKgs * 0.2;
else if (luggageKgs <= 20) luggageTaxes = luggagePriceAboveTwentyKgs * 0.5;
else luggageTaxes = luggagePriceAboveTwentyKgs;

if (daysUntilTravel > 30) luggageTaxes *= 1.10;
else if (daysUntilTravel >= 7) luggageTaxes *= 1.15;
else luggageTaxes *= 1.40;

double totalPrice = luggageCount * luggageTaxes;

Console.WriteLine($"The total price of bags is: {totalPrice:F2} lv.");