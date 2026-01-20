int pencilPackages = int.Parse(Console.ReadLine());
int markerPackages = int.Parse(Console.ReadLine());
int claeningAgentInLiters = int.Parse(Console.ReadLine());
int discountPercentage = int.Parse(Console.ReadLine());

const double pricePerPencilPackage = 5.80;
const double pricePerMarkerPackages = 7.20;
const double pricePerClaeningAgentInLiters = 1.20;

double resultWithoutDiscount = pencilPackages * pricePerPencilPackage + markerPackages * pricePerMarkerPackages + claeningAgentInLiters * pricePerClaeningAgentInLiters;
double resultWithDiscount = resultWithoutDiscount - (resultWithoutDiscount * discountPercentage / 100);

Console.WriteLine(resultWithDiscount);
