int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

int freeSpace = width * length * height;

string input = Console.ReadLine();
while (input != "Done" && freeSpace > 0)
{
    int boxes = int.Parse(input);
    freeSpace -= boxes;

    input = Console.ReadLine();
}

if (freeSpace >= 0) Console.WriteLine($"{freeSpace} Cubic meters left.");
else Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");