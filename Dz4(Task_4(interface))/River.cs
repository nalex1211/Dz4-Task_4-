namespace Dz4_Task_4_interface__;

internal class River : IGeogObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    private int Length;
    private int Speed;

    public River(double x, double y, string name, string description, int length, int speed)
    {
        X = x;
        Y = y;
        Name = name;
        Description = description;
        Length = length;
        Speed = speed;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Name of object: {Name}");
        Console.WriteLine($"X coordinates: {X}");
        Console.WriteLine($"Y coordinates: {Y}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Length of river: {Length}");
        Console.WriteLine($"Speed of river: {Speed}");
    }
}
