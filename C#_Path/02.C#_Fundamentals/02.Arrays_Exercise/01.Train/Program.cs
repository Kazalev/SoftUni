int n = int.Parse(Console.ReadLine());
int[] wagons = new int[n];

for (int i = 0; i < wagons.Length; i++)
{
    int passengers = int.Parse(Console.ReadLine());
    wagons[i] = passengers;
}

for (int i = 0; i < wagons.Length; i++)
{
    Console.Write($"{wagons[i]} ");
}

Console.WriteLine();
Console.WriteLine(wagons.Sum());