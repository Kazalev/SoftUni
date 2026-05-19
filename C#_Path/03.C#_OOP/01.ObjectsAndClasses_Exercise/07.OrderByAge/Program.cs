class Program
{
    class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public Person(string name, string id, int age)
        {
            Id = id;
            Age = age;
            Name = name;
        }

        public string Print()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
    static void Main()
    {
        List<Person> list = new List<Person>();

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] args = command.Split();

            string name = args[0];
            string id = args[1];
            int age = int.Parse(args[2]);

            Person found = list.FirstOrDefault(p => p.Id == id);

            if (found != null)
            {
                found.Age = age;
                found.Name = name;
            }
            else
            {
                list.Add(new Person(name, id, age));
            }

        }

        List<Person> orderedPersons = list.OrderBy(person => person.Age).ToList();
        foreach (Person person in orderedPersons)
        {
            Console.WriteLine(person.Print());
        }
    }
}