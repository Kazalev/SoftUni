const string phrase = "s3cr3t!P@ssw0rd";

string password = Console.ReadLine();

if(phrase == password)
    Console.WriteLine("Welcome");
else
    Console.WriteLine("Wrong password!");