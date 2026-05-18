Dictionary<string, int> carKilometers = new Dictionary<string, int>();
Dictionary<string, int> carFuel = new Dictionary<string, int>();

int carsCount = int.Parse(Console.ReadLine());

for (int i = 0; i < carsCount; i++)
{
    string[] carData = Console.ReadLine().Split("|");
    string car = carData[0];
    int kilometers = int.Parse(carData[1]);
    int fuel = int.Parse(carData[2]);

    carKilometers.Add(car, kilometers);
    carFuel.Add(car, fuel);
}

string command = "";
while ((command = Console.ReadLine()) != "Stop")
{
    string[] arguments = command.Split(" : ");
    string carName = arguments[1];

    switch (arguments[0])
    {
        case "Drive":
            int distance = int.Parse(arguments[2]);
            int fuelNeeded = int.Parse(arguments[3]);

            Drive(carName, distance, fuelNeeded, carKilometers, carFuel);
            break;
        case "Refuel":
            int fuelToAdd = int.Parse(arguments[2]);

            break;
        case "Revert":
            int kmToRevert = int.Parse(arguments[2]);

            break;
    }
}

static void Drive(string car, int distance, int fuelNeeded, Dictionary<string, int> carKilometers, Dictionary<string, int> carFuel)
{
    if (carFuel[car] < fuelNeeded)
    {
        Console.WriteLine($"Not enough fuel to make the ride");
    }
    else
    {
        carKilometers[car] += distance;
        carFuel[car] -= fuelNeeded;
        Console.WriteLine($"{car} driven for {distance} kilometers. {fuelNeeded} liters of fuel consumed.");
    }

    if (carKilometers[car] >= 100_000)
    {
        Console.WriteLine($"Time to sell the {car}!");
    }
}

static void Refuel(string car, int fuelToAdd, Dictionary<string, int> carFuel)
{
    if (carFuel[car] + fuelToAdd > 75)
    {
        fuelToAdd = 75 - carFuel[car];
    }

    carFuel[car] = Math.Clamp(carFuel[car] + fuelToAdd, 0, 75);
}

foreach (KeyValuePair<string, int> car in carKilometers)
{
    Console.WriteLine($"{car.Key} -> Mileage: {car.Value} kms, Fuel in the tank: {carFuel[car.Key]} lt.");
}