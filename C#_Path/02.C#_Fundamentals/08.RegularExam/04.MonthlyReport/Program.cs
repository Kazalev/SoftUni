Dictionary<string, double> distributors = new Dictionary<string, double>();
Dictionary<string, double> clients = new Dictionary<string, double>();

string command = "";
while ((command = Console.ReadLine()) != "End")
{
    string[] arguments = command.Split();

    switch (arguments[0])
    {
        case "Deliver":
            Deliver(arguments[1], double.Parse(arguments[2]));
            break;
        case "Return":
            Return(arguments[1], double.Parse(arguments[2]));
            break;
        case "Sell":
            Sell(arguments[1], double.Parse(arguments[2]));
            break;
    }
}

PrintAllClientsAndSpentMoney();
Console.WriteLine("-----------");
PrintAllDistributorsAndTotalCost();
Console.WriteLine("-----------");
PrintTotalIncome();

void Deliver(string distributorName, double moneySpent)
{
    if (distributors.ContainsKey(distributorName)) distributors[distributorName] += moneySpent;
    else distributors[distributorName] = moneySpent;
}

void Return(string distributorName, double moneyReturned)
{
    if (distributors.ContainsKey(distributorName) && distributors[distributorName] >= moneyReturned)
    {
        distributors[distributorName] -= moneyReturned;
        if (distributors[distributorName] <= 0) distributors.Remove(distributorName);
    }
}

void Sell(string clientName, double moneyEarned)
{
    if (clients.ContainsKey(clientName)) clients[clientName] += moneyEarned;
    else clients[clientName] = moneyEarned;
}

void PrintAllClientsAndSpentMoney()
{
    foreach (var client in clients)
    {
        Console.WriteLine($"{client.Key}: {client.Value:F2}");
    }
}

void PrintAllDistributorsAndTotalCost()
{
    foreach (var distributor in distributors)
    {
        Console.WriteLine($"{distributor.Key}: {distributor.Value:F2}");
    }
}

void PrintTotalIncome()
{
    double totalIncome = clients.Values.Sum();
    Console.WriteLine($"Total Income: {totalIncome:F2}");
}