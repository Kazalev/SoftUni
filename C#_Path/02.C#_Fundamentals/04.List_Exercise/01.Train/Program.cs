List<int> waggons = Console.ReadLine().Split().Select(int.Parse).ToList();
int maxCapacity = int.Parse(Console.ReadLine());

string command = "";
while ((command = Console.ReadLine()) != "end")
{
    string[] arguments = command.Split();
    List<string> arguments1 = command.Split().ToList();

    if (arguments[0] == "Add")
    {
        waggons.Add(int.Parse(arguments[1]));
    }
    else
    {
        int newPassengers = int.Parse(arguments[0]);

        for (int i = 0; i < waggons.Count; i++)
        {
            if (waggons[i] + newPassengers <= maxCapacity)
            {
                waggons[i] += newPassengers;
                break;
            }
        }
    }
}

Console.WriteLine(String.Join(" ", waggons));