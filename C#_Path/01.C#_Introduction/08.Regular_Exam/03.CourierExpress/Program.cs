double packageKgs = double.Parse(Console.ReadLine());
string type = Console.ReadLine();
int distanceInKm = int.Parse(Console.ReadLine());

double pricePerKm = 0;
double finalPrice = 0;

if (packageKgs < 1) pricePerKm = 0.03;
else if (packageKgs < 10) pricePerKm = 0.05;
else if (packageKgs < 40) pricePerKm = 0.10;
else if (packageKgs < 90) pricePerKm = 0.15;
else pricePerKm = 0.20;

if (type == "standard") finalPrice = distanceInKm * pricePerKm;
else if (type == "express")
{
    double percent = 0;
    if (packageKgs < 1) percent = 0.80;
    else if (packageKgs < 10) percent = 0.40;
    else if (packageKgs < 40) percent = 0.05;
    else if (packageKgs < 90) percent = 0.02;
    else if (packageKgs < 150) percent = 0.01;

    double surchargePerKm = pricePerKm * percent * packageKgs;
    double totalPerKm = pricePerKm + surchargePerKm;

    finalPrice = distanceInKm * totalPerKm;
}

Console.WriteLine($"The delivery of your shipment with weight of {packageKgs:F3} kg. would cost {finalPrice:F2} lv.");