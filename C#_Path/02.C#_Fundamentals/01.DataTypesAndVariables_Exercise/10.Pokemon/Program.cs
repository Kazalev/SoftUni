int energy = int.Parse(Console.ReadLine());
int distance = int.Parse(Console.ReadLine());
int factor = int.Parse(Console.ReadLine());

int pokeCount = 0;
double halfEnergy = energy * 0.5D;

while (energy >= distance)
{
    pokeCount++;
    energy -= distance;

    if (halfEnergy == energy && factor != 0)
    {
        energy /= factor;
    }
}

Console.WriteLine(energy);
Console.WriteLine(pokeCount);