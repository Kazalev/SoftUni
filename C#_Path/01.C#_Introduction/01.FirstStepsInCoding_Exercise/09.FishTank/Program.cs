int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine());

double volume = length * width * height;
double volumeInLiters = volume / 1000;
percent = percent / 100;

double water = volumeInLiters * (1 - percent);
Console.WriteLine(water);
