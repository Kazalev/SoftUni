class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Hometown { get; set; }

    public Student(string firstName, string lastName, int age, string hometown)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Hometown = hometown;
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        string command = "";
        while ((command = Console.ReadLine()) != "end")
        {
            string[] arguments = command.Split();

            Student newStudent = new Student(arguments[0], arguments[1], int.Parse(arguments[2]), arguments[3]);

            students.Add(newStudent);
        }

        string town = Console.ReadLine();

        foreach (Student student in students)
        {
            if (student.Hometown == town)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}