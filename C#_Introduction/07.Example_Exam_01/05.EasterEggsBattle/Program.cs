int playerOne = int.Parse(Console.ReadLine());
int playerTwo = int.Parse(Console.ReadLine());

string input = "";

while ((input = Console.ReadLine()) != "End")
{
    if (input == "one") playerTwo --;
    else if (input == "two") playerOne --;

    if (playerOne == 0 || playerTwo == 0) break;
}

if (playerOne == 0) Console.WriteLine($"Player one is out of eggs. Player two has {playerTwo} eggs left.");
else if (playerTwo == 0) Console.WriteLine($"Player two is out of eggs. Player one has {playerOne} eggs left.");
else
{
    Console.WriteLine($"Player one has {playerOne} eggs left.");
    Console.WriteLine($"Player two has {playerTwo} eggs left.");
}