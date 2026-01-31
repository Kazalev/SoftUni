string type = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int cols = int.Parse(Console.ReadLine());

double price = 0;

if (type == "Premiere") price = 12.0;
else if (type == "Normal") price = 7.50;
else if (type == "Discount") price = 5;

double total = rows * cols * price;

Console.WriteLine($"{total:F2} leva");
