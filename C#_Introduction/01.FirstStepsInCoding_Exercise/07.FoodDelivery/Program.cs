int chikenMenu = int.Parse(Console.ReadLine());
int fishMenu = int.Parse(Console.ReadLine());
int vegetarianMenu = int.Parse(Console.ReadLine());

const double chikenMenuPrice = 10.35;
const double fishMenuPrice = 12.40;
const double vegetarianMenuPrice = 8.15;
const double deliveryPrice = 2.50;

double totalMenusPrice = (chikenMenu * chikenMenuPrice) + (fishMenu * fishMenuPrice) + (vegetarianMenu * vegetarianMenuPrice);
double dessertPrice = totalMenusPrice * 20 / 100;

Console.WriteLine(totalMenusPrice + dessertPrice + deliveryPrice);