string text = Console.ReadLine();

int result = 0;

for (int i = 0; i < text.Length; i++)
{
    if (text[i] == 'a') result += 1;
    if (text[i] == 'e') result += 2;
    if (text[i] == 'i') result += 3;
    if (text[i] == 'o') result += 4;
    if (text[i] == 'u') result += 5;
}

Console.WriteLine(result);
