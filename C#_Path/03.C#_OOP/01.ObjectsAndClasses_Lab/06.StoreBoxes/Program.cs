class Item
{
    public string Name { get; set; }
    public double Price { get; set; }
}

class Box
{
    public Box()
    {
        Item = new Item();
    }

    public string SerialNumber { get; set; }
    public Item Item { get; set; }
    public int Quantity { get; set; }
    public decimal PriceBox { get; set; }
}


class Program
{
    static void Main()
    {
        List<Box> boxes = new List<Box>();
        string command = "";
        while ((command = Console.ReadLine()) != "end")
        {

            string[] args = command.Split();

            string serialNumber = args[0];
            string itemName = args[1];
            int quantity = int.Parse(args[2]);
            double itemPrice = double.Parse(args[3]);

            Box newBox = new Box();
            newBox.SerialNumber = serialNumber;
            newBox.Item.Name = itemName;
            newBox.Item.Price = itemPrice;
            newBox.Quantity = quantity;
            newBox.PriceBox = (decimal)(quantity * itemPrice);
            boxes.Add(newBox);
        }

        foreach (Box box in boxes.OrderByDescending(x => x.PriceBox))
        {
            Console.WriteLine(box.SerialNumber);
            Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.Quantity}");
            Console.WriteLine($"-- ${box.PriceBox:F2}");
        }
    }
}