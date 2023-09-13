using ComputerStore.Models;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Keyboard>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var keyboard = new Keyboard();

    Console.WriteLine("Enter the keyboard model name: ");
    keyboard.Name = Console.ReadLine();

    Console.WriteLine("Enter a brief description of the keyboard: ");
    keyboard.Description = Console.ReadLine();

    Console.WriteLine("Enter the quantity in stock: ");
    keyboard.QuantityInStock = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the unit price: ");
    keyboard.UnitPrice = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Enter the peripheral type: ");
    keyboard.Type = Console.ReadLine();

    Console.WriteLine("Enter the connection type: ");
    keyboard.ConnectionType = Console.ReadLine();

    Console.WriteLine("Enter the keyboard size: ");
    keyboard.Size = Console.ReadLine();

    Console.WriteLine("Enter the keyboard color: ");
    keyboard.Color = Console.ReadLine();

    Console.WriteLine("Does the keyboard have a number pad? (true/false): ");
    keyboard.HasNumberPad = bool.Parse(Console.ReadLine());

    Console.WriteLine("Does the keyboard have RGB? (true/false): ");
    keyboard.HasRGB = bool.Parse(Console.ReadLine());


    recordList.Add(keyboard);
}

// Print out the list of records using Console.WriteLine()

foreach (var item in recordList)
{
    Console.WriteLine(item);
}