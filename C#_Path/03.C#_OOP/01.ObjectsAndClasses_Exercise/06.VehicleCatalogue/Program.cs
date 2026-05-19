class Program
{
    enum Type
    {
        Car,
        Truck
    }

    class Vehicle
    {
        public Type Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal HP { get; set; }

        public Vehicle(string type, string model, string color, string hp)
        {
            Type = type == "car" ? Type.Car : Type.Truck;
            Model = model;
            Color = color;
            HP = decimal.Parse(hp);
        }

        public string Print()
        {
            return $"Type: {Type}\n" +
                   $"Model: {Model}\n" +
                   $"Color: {Color}\n" +
                   $"Horsepower: {HP}";
        }
    }

    static void Main()
    {
        List<Vehicle> catalogue = new List<Vehicle>();

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] args = command.Split();

            Vehicle newVehicle = new Vehicle(args[0], args[1], args[2], args[3]);
            catalogue.Add(newVehicle);
        }

        while ((command = Console.ReadLine()) != "Close the Catalogue")
        {
            string vehicleModel = command;

            Vehicle found = catalogue.FirstOrDefault(c => c.Model == vehicleModel);

            if (found != null)
            {
                Console.WriteLine(found.Print());
            }
        }

        decimal averageHP = catalogue
            .Where(v => v.Type == Type.Car)
            .Select(v => v.HP)
            .DefaultIfEmpty()
            .Average();
        Console.WriteLine($"Cars have average horsepower of: {averageHP:F2}.");

        averageHP = catalogue
            .Where(v => v.Type == Type.Truck)
            .Select(v => v.HP)
            .DefaultIfEmpty()
            .Average();
        Console.WriteLine($"Trucks have average horsepower of: {averageHP:F2}.");
    }
}