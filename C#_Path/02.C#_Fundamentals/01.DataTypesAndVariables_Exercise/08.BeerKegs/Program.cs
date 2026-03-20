string biggestKegModel = "";
double biggestKegVolume = 0;

byte n = byte.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string model = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());

    double volume = Math.PI * Math.Pow(radius, 2) * height;

    if (biggestKegVolume < volume)
    {
        biggestKegVolume = volume;
        biggestKegModel = model;
    }
}

Console.WriteLine(biggestKegModel);