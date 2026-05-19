class Program
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }

    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        List<Student> students = new List<Student>();

        for (int i = 0; i < count; i++) {
            string[] stringStudent = Console.ReadLine().Split();
            Student newStudent = new Student();
            newStudent.FirstName = stringStudent[0];
            newStudent.LastName = stringStudent[1];
            newStudent.Grade = double.Parse(stringStudent[2]);
            students.Add(newStudent);
        }

        foreach (Student student in students.OrderByDescending(s => s.Grade))
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
        }
    }
}