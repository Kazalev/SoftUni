int nylon = int.Parse(Console.ReadLine());
int paint = int.Parse(Console.ReadLine());
int thinner = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());

const double priceForProtectiveNylonPerSquare = 1.50;
const double priceForPaintPerLiter = 14.50;
const double priceForPaintThinner = 5.00;
const double priceForBags = 0.40;

double totalMaterialPrice = ((nylon + 2) * priceForProtectiveNylonPerSquare) + (paint * 1.1 * priceForPaintPerLiter) + (thinner * priceForPaintThinner) + priceForBags;
double priceForWorkers = totalMaterialPrice * 30 / 100 * hours;

Console.WriteLine(totalMaterialPrice + priceForWorkers);
