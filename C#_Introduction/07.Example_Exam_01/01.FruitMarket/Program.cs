double strawberryPrice = double.Parse(Console.ReadLine());
double bananaKg = double.Parse(Console.ReadLine());
double orangeKg = double.Parse(Console.ReadLine());
double raspberryKg = double.Parse(Console.ReadLine());
double strawberryKg = double.Parse(Console.ReadLine());

double raspberryPrice = strawberryPrice / 2;
double orangePrice = raspberryPrice - (0.4 * raspberryPrice);
double bananaPrice = raspberryPrice - (0.8 * raspberryPrice);

double raspberryTotal = raspberryPrice * raspberryKg;
double orangeTotal = orangePrice * orangeKg;
double bananaTotal = bananaPrice * bananaKg;
double strawberryTotal = strawberryPrice * strawberryKg;

double total = raspberryTotal + orangeTotal + bananaTotal + strawberryTotal;

Console.WriteLine($"{total:F2}");