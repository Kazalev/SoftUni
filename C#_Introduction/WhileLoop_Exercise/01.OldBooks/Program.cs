string bookToSearch = Console.ReadLine();

int bookCount = 0;
bool bookFound = false;

string input;
while ((input = Console.ReadLine()) != "No More Books")
{
    if (input == bookToSearch)
    {
        bookFound = true;
        break;
    }

    bookCount++;
}

if (bookFound) Console.WriteLine($"You checked {bookCount} books and found it.");
else
{
    Console.WriteLine("The book you search is not here!");
    Console.WriteLine($"You checked {bookCount} books.");
}