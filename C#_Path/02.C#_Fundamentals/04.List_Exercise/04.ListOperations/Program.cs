List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

string command = "";
while ((command = Console.ReadLine()) != "End")
{
    List<string> arguments = command.Split().ToList();

    int number;
    int index;
    switch (arguments[0])
    {
        case "Add":
            number = int.Parse(arguments[1]);
            list = AddNumber(list, number);
            break;
        case "Insert":
            number = int.Parse(arguments[1]);
            index = int.Parse(arguments[2]);
            list = InsertNumberAt(list, number, index);
            break;
        case "Remove":
            index = int.Parse(arguments[1]);
            list = RemoveAt(list, index);
            break;
        case "Shift":
            string direction = arguments[1];
            int count = int.Parse(arguments[2]);
            count %= list.Count;

            switch (direction)
            {
                case "left":
                    List<int> shiftedPart = list.GetRange(0, count);
                    list.RemoveRange(0, count);
                    list.InsertRange(list.Count, shiftedPart);
                    break;
                case "right":
                    shiftedPart = list.GetRange(list.Count - count, count);
                    list.RemoveRange(list.Count - count, count);
                    list.InsertRange(0, shiftedPart);
                    break;
            }
            break;
    }
}

Console.WriteLine(String.Join(" ", list));

static List<int> AddNumber(List<int> list, int number)
{
    list.Add(number);
    return list;
}
static List<int> InsertNumberAt(List<int> list, int number, int index)
{
    if (IsValidIndex(list, index)) list.Insert(index, number);
    return list;
}

static List<int> RemoveAt(List<int> list, int index)
{
    if (IsValidIndex(list, index)) list.RemoveAt(index);
    return list;
}

static bool IsValidIndex(List<int> list, int index)
{
    bool isValid = index >= 0 && index < list.Count;

    if (isValid) return true;
    else
    {
        Console.WriteLine("Invalid index");
        return false;
    }
}