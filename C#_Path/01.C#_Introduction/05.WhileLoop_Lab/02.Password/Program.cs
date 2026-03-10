string username = Console.ReadLine();
string password = Console.ReadLine();
string input = Console.ReadLine();

while (password != input)
{
    input = Console.ReadLine();
}

Console.WriteLine($"Welcome {username}!");