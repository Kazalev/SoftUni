string str = Console.ReadLine();
int count = int.Parse(Console.ReadLine());

string result = RepeatString(count, str);
Console.WriteLine(result);

static string RepeatString(int count, string str)
{
    string result = string.Empty;

	for (int i = 0; i < count; i++)
	{
		result += str;
	}

	return result;
}