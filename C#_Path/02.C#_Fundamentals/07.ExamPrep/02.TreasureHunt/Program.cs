List<string> treasures = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();

string command;
while ((command = Console.ReadLine()) != "Yohoho!")
{
    List<string> arguments = command.Split().ToList();

    switch (arguments[0])
    {
        case "Loot":
            var loot = arguments.GetRange(1, arguments.Count - 1);
            LootItems(treasures, loot);
            break;
        case "Drop":
            int index = int.Parse(arguments[1]);
            DropItem(treasures, index);
            break;
        case "Steal":
            int count = int.Parse(arguments[1]);
            StealItems(treasures, count);
            break;
    }
}

if (treasures.Count == 0)
{
    Console.WriteLine("Failed treasure hunt.");
}
else
{
    double sumOfLengths = treasures.Sum(item => item.Length) / treasures.Count;
    double averageGain = sumOfLengths / treasures.Count;
    Console.WriteLine($"Average treasure gain: {averageGain:F2} pirate credits.");
}

static void LootItems(List<string> treasures, List<string> loot)
{
    for (int i = 0; i < loot.Count; i++)
    {
        if (!treasures.Contains(loot[i]))
        {
            treasures.Insert(0, loot[i]);
        }
    }
}

static void DropItem(List<string> treasures, int index)
{
    if (index >= 0 && index < treasures.Count)
    {
        string item = treasures[index];
        treasures.RemoveAt(index);
        treasures.Add(item);
    }
}

static void StealItems(List<string> treasures, int count)
{
    int actualCount = Math.Min(count, treasures.Count);
    int startIndex = treasures.Count - actualCount;

    List<string> stolenItems = treasures.GetRange(startIndex, actualCount);
    treasures.RemoveRange(startIndex, actualCount);

    Console.WriteLine(String.Join(", ", stolenItems));
}