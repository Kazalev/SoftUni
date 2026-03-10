int frames = int.Parse(Console.ReadLine());
string frameSize = Console.ReadLine();
string deliveryType = Console.ReadLine();

if (frames < 10)
{
    Console.WriteLine("Invalid order");
    return;
}

double singlePrice = 0;

if (frameSize == "90X130")
{
    singlePrice = 110;

    if (frames > 30 && frames <= 60) singlePrice *= 0.95;
    if (frames > 60) singlePrice *= 0.92;
}
else if (frameSize == "100X150")
{
    singlePrice = 140;

    if (frames > 40 && frames <= 80) singlePrice *= 0.94;
    if (frames > 80) singlePrice *= 0.90;
}
else if (frameSize == "130X180")
{
    singlePrice = 190;

    if (frames > 20 && frames <= 50) singlePrice *= 0.92;
    if (frames > 50) singlePrice *= 0.88;
}
else if (frameSize == "200X300")
{
    singlePrice = 250;

    if (frames > 25 && frames <= 50) singlePrice *= 0.91;
    if (frames > 50) singlePrice *= 0.86;
}

double total = singlePrice * frames;
if (deliveryType == "With delivery") total += 60;
if (frames > 99) total *= 0.96;

Console.WriteLine($"{total:F2} BGN");