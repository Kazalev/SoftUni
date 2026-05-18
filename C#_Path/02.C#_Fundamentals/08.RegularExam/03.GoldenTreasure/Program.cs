using System.Text;

string inputPassword = Console.ReadLine();
StringBuilder passwordToMath = new StringBuilder("");
bool foundTreasure = false;
bool isFreeze = false;
int freezeCounter = 0;

string command = "";
while ((command = Console.ReadLine()) != "Error")
{
    string[] arguments = command.Split();

    if (isFreeze)
    {
        freezeCounter++;
        if (freezeCounter == 2) isFreeze = false;
        continue;
    }

    switch (arguments[0])
    {
        case "Infuse":
            string charsToAdd = arguments[1];
            AddCharsToEndAndPrint(charsToAdd);
            break;
        case "Transpose":
            int index1 = int.Parse(arguments[1]);
            int index2 = int.Parse(arguments[2]);
            SwapIndexesAndPrint(index1, index2);
            break;
        case "Retrace":
            int index = int.Parse(arguments[1]);
            ReversePartOfStringAndPrint(index);
            break;
        case "Destroy":
            string characterToRemove = arguments[1];
            RemoveAllOccurrencesAndPrint(characterToRemove);
            break;
        case "Freeze":
            isFreeze = true;
            break;
    }

    if (passwordToMath.ToString() == inputPassword)
    {
        foundTreasure = true;
        break;
    }
}

if (foundTreasure) Console.WriteLine("The Golden Treasure has been unlocked!");
else Console.WriteLine($"The string {passwordToMath} does not match the password {inputPassword}!");

void AddCharsToEndAndPrint(string charsToAdd)
{
    passwordToMath.Append(charsToAdd);
    Console.WriteLine(passwordToMath);
}

void SwapIndexesAndPrint(int index1, int index2)
{
    if (CheckValidIndex(passwordToMath, index1) && CheckValidIndex(passwordToMath, index2))
    {
        char temp = passwordToMath[index1];
        passwordToMath[index1] = passwordToMath[index2];
        passwordToMath[index2] = temp;

        Console.WriteLine(passwordToMath);
    }
    else
    {
        Console.WriteLine("Failed attempt to unlock the treasure");
    }
}

void ReversePartOfStringAndPrint(int index)
{
    if (CheckValidIndex(passwordToMath, index))
    {
        string partToReverse = passwordToMath.ToString().Substring(0, index + 1);
        string reversedPart = new string(partToReverse.Reverse().ToArray());
        passwordToMath.Remove(0, index + 1);
        passwordToMath.Insert(0, reversedPart);
        Console.WriteLine(passwordToMath);
    }
}

void RemoveAllOccurrencesAndPrint(string characterToRemove)
{
    int foundAtIndex = passwordToMath.ToString().IndexOf(characterToRemove);
    if (foundAtIndex > -1)
    {
        passwordToMath.Replace(characterToRemove, "");
        Console.WriteLine(passwordToMath);
    }
    else
    {
        Console.WriteLine($"Character {characterToRemove} is invalid");
    }
}

bool CheckValidIndex(StringBuilder passwordToMath, int index)
{
    return index >= 0 && index < passwordToMath.Length;
}