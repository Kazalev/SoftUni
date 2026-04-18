string pass = Console.ReadLine();

bool lengthCheckPassed = CheckLength(pass);
bool symbolCheckValue = CheckSpecialSymbols(pass);
bool twoDigitCheckPass = CheckForTwoDigits(pass);

if (!lengthCheckPassed) Console.WriteLine("Password must be between 6 and 10 characters");
if (!symbolCheckValue) Console.WriteLine("Password must consist only of letters and digits");
if (!twoDigitCheckPass) Console.WriteLine("Password must have at least 2 digits");

if (lengthCheckPassed && symbolCheckValue && twoDigitCheckPass) Console.WriteLine("Password is valid");

static bool CheckLength(string password)
{
    if (password.Length < 6 || password.Length > 10) return false;
    else return true;
}

static bool CheckSpecialSymbols(string password)
{
    for (int i = 0; i < password.Length; i++)
    {
        char symbol = password[i];
        if (symbol >= 65 && symbol <= 90 || symbol >= 97 && symbol <= 122 || symbol >= 48 && symbol <= 57)
        {
            continue;
        }
        else
        {
            return false;
        }
    }

    return true;
}


static bool CheckForTwoDigits(string pass)
{
    int count = 0;

    for (int i = 0; i < pass.Length; i++)
    {
        char symbol = pass[i];
        if (symbol >= 48 && symbol <= 57) count++;
    }

    if (count < 2) return false;
    else return true;
}