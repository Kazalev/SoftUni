int n = int.Parse(Console.ReadLine());
int capacity = 255;
int tank = 0;

for (int i = 0; i < n; i++)
{
    int liters = int.Parse(Console.ReadLine());

    if (tank + liters > capacity) Console.WriteLine("Insufficient capacity!");
    else tank += liters;
}

Console.WriteLine(tank);