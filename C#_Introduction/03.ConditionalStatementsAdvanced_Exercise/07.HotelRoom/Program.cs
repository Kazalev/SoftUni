string month = Console.ReadLine();
int nights = int.Parse(Console.ReadLine());

double studioPrice = 0;
double apartmentPrice = 0;

if (month == "May" || month == "October")
{
    studioPrice = 50;
    apartmentPrice = 65;
}
else if (month == "June" || month == "September")
{
    studioPrice = 75.20;
    apartmentPrice = 68.70;
}
else if (month == "July" || month == "August")
{
    studioPrice = 76;
    apartmentPrice = 77;
}

double studioTotal = studioPrice * nights;
double apartmentTotal = apartmentPrice * nights;

if ((month == "May" || month == "October") && nights > 14) studioTotal = studioTotal * 0.70;
else if ((month == "May" || month == "October") && nights > 7) studioTotal = studioTotal * 0.95;
else if ((month == "June" || month == "September") && nights > 14) studioTotal = studioTotal * 0.80;

if (nights > 14) apartmentTotal = apartmentTotal * 0.90;

Console.WriteLine($"Apartment: {apartmentTotal:F2} lv.");
Console.WriteLine($"Studio: {studioTotal:F2} lv.");
