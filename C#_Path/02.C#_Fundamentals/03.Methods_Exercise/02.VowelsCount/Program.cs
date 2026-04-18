string str = Console.ReadLine();

PrintVowelsNumber(str);

static void PrintVowelsNumber(string str)
{
    int count = 0;

    for (int i = 0; i < str.Length; i++)
    {
        char letter = Char.ToUpper(str[i]);
        if (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' || letter == 'Y') count++;
    }

    Console.WriteLine(count);
}