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
            string firstName = arguments[0];
            string lastName = arguments[1];
            int age = int.Parse(arguments[2]);
            string hometown = arguments[3];

            if (IsStudentExisting(students, firstName, lastName))
            {
                Student student = GetStudent(students, firstName, lastName);

                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.Hometown = hometown;
            }
            else
            {
                Student newStudent = new Student(firstName, lastName, age, hometown);
                students.Add(newStudent);
            }
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
    static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
    {
        foreach (Student student in students)
        {
            if (student.FirstName == firstName && student.LastName == lastName)
            {
                return true;
            }
        }
        return false;
    }

    static Student GetStudent(List<Student> students, string firstName, string lastName)
    {
        Student existingStudent = null;

        foreach (Student student in students)
        {
            if (student.FirstName == firstName && student.LastName == lastName)
            {
                existingStudent = student;
            }
        }

        return existingStudent;

    }
}