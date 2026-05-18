int energy = int.Parse(Console.ReadLine());
int wonBattles = 0;

string command = "";
while ((command = Console.ReadLine()) != "End of battle")
{
    int distance = int.Parse(command);

    if (energy >= distance)
    {
        energy -= distance;
        wonBattles++;

        if (wonBattles % 3 == 0) energy += wonBattles;
    }
    else
    {
        Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {energy} energy");
        return;
    }
}

Console.WriteLine($"Won battles: {wonBattles}. Energy left: {energy}");