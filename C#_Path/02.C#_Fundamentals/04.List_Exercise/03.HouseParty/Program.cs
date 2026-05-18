int guestCount = int.Parse(Console.ReadLine());

List<string> guestList = new List<string>();

for (int i = 0; i < guestCount; i++)
{
    List<string> arguments = Console.ReadLine().Split().ToList();

    string name = arguments[0];
    string action = arguments[2];

    if (action == "going!")
    {
        if (guestList.Contains(name)) Console.WriteLine($"{name} is already in the list!");
        else guestList.Add(name);
    }
    else if (action == "not")
    {
        if (!guestList.Remove(name)) Console.WriteLine($"{name} is not in the list!");

        //int foundIndex = guestList.IndexOf(name);
        //if (foundIndex == -1) Console.WriteLine($"{name} is not in the list!");
        //else guestList.RemoveAt(foundIndex);
    }
}

foreach (string guest in guestList)
{
    Console.WriteLine(guest);
}