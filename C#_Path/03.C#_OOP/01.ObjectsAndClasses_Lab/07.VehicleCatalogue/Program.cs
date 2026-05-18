class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }
}

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Horsepower { get; set; }
}

class Catalog
{
    public List<Truck> TrucksCollection { get; set; }
    public List<Car> CarsCollection { get; set; }
}

class Program
{
    static void Main()
    {
        Catalog catalog = new Catalog();
        catalog.CarsCollection = new List<Car>();
        catalog.TrucksCollection = new List<Truck>();

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            string[] commandArgs = command.Split('/');
            string type = commandArgs[0];
            string brand = commandArgs[1];
            string model = commandArgs[2];
            int horsepowerOrWeight = int.Parse(commandArgs[3]);

            switch (type)
            {
                case "Car":
                    Car car = new Car
                    {
                        Brand = brand,
                        Model = model,
                        Horsepower = horsepowerOrWeight
                    };
                    catalog.CarsCollection.Add(car);
                    break;
                case "Truck":
                    Truck truck = new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = horsepowerOrWeight
                    };
                    catalog.TrucksCollection.Add(truck);
                    break;
            }
        }

        if (catalog.CarsCollection.Any())
        {
            Console.WriteLine("Cars:");
            foreach (Car car in catalog.CarsCollection.OrderBy(c => c.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.Horsepower}hp");
            }
        }

        if (catalog.TrucksCollection.Any())
        {
            Console.WriteLine("Trucks:");
            foreach (Truck truck in catalog.TrucksCollection.OrderBy(t => t.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
}