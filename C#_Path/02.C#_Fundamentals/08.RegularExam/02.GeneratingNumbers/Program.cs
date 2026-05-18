List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string command = "";
while ((command = Console.ReadLine()) != "END")
{
    List<string> arguments = command.Split().ToList();

    switch (arguments[0])
    {
        case "add":
            var numbersToAdd = arguments.GetRange(3, arguments.Count - 3).Select(int.Parse);
            numbers.InsertRange(0, numbersToAdd);
            break;
        case "remove":
            string type = arguments[1];
            string typeTwo = arguments[2];

            if (type == "greater" && typeTwo == "than")
            {
                int valueNumber = int.Parse(arguments[3]);
                numbers.RemoveAll(x => x > valueNumber);
            }
            else if (type == "at" && typeTwo == "index")
            {
                int index = int.Parse(arguments[3]);
                if (index >= 0 && index < numbers.Count) numbers.RemoveAt(index);
            }
            break;
        case "replace":
            int value = int.Parse(arguments[1]);
            int replacement = int.Parse(arguments[2]);

            int foundIndex = numbers.FindIndex(item => item == value);
            if (foundIndex >= 0)
            {
                numbers.RemoveAt(foundIndex);
                numbers.Insert(foundIndex, replacement);
            }
            break;
        case "find":
            if (arguments[1] == "even") Console.WriteLine(String.Join(" ", numbers.Where(item => item % 2 == 0)));
            else if (arguments[1] == "odd") Console.WriteLine(String.Join(" ", numbers.Where(item => item % 2 != 0)));
            break;
    }
}

Console.WriteLine(String.Join(", ", numbers));