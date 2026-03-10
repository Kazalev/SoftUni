int foodPackagesForDogs = int.Parse(Console.ReadLine());
int foodPackagesForCats = int.Parse(Console.ReadLine());

double totalPrice = foodPackagesForDogs * 2.5 + foodPackagesForCats * 4;

Console.WriteLine($"{totalPrice} lv.");