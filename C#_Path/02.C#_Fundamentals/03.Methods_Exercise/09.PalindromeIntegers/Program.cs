string command;
while ((command = Console.ReadLine()) != "END")
{
    int number = int.Parse(command);
    Console.WriteLine(isPalindrome(number));
}

static bool isPalindrome(int n)
{
    int original = n;
    int reversed = 0;

    while (n > 0)
    {
        int digit = n % 10;
        reversed = reversed * 10 + digit;
        n /= 10;
    }

    return original == reversed;

}

static bool isPalindromeStringApproach(int n)
{
    string str = n.ToString();
    char[] reversed = str.Reverse().ToArray();
    return str == new string(reversed);
}