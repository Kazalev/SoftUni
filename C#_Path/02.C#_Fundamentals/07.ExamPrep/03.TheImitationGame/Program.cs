using System.Text;

string inputMessage = Console.ReadLine();
StringBuilder message = new StringBuilder(inputMessage);

string command = "";
while ((command = Console.ReadLine()) != "Decode")
{
    string[] arguments = command.Split("|");

    switch (arguments[0])
    {
        case "Move":
            int numberOfLetters = int.Parse(arguments[1]);
            if (numberOfLetters > 0 && numberOfLetters < message.Length)
            {
                string lettersToMove = message.ToString().Substring(0, numberOfLetters);
                message.Remove(0, numberOfLetters);
                message.Append(lettersToMove);
            }
            break;
        case "Insert":
            int index = int.Parse(arguments[1]);
            string value = arguments[2];
            message.Insert(index, value);
            break;
        case "ChangeAll":
            string substring = arguments[1];
            string replacement = arguments[2];
            message.Replace(substring, replacement);
            break;
    }
}

Console.WriteLine($"The decrypted message is: {message.ToString()}");