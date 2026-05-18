List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string command = "";
while ((command = Console.ReadLine()) != "end")
{
    string[] commandArgs = command.Split();

    switch (commandArgs[0])
    {
        case "Delete":
            int numberToDelete = int.Parse(commandArgs[1]);
            numbers.RemoveAll(n => n == numberToDelete);
            break;
        case "Insert":
            int numberToInsert = int.Parse(commandArgs[1]);
            int indexToInsert = int.Parse(commandArgs[2]);
            numbers.Insert(indexToInsert, numberToInsert);
            break;
    }
}

Console.WriteLine(String.Join(" ", numbers));