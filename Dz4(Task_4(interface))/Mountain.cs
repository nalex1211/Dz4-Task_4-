namespace Dz4_Task_4_interface__;

internal class Mountain : IGeogObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    private int HighestPoint;

    public Mountain(double x, double y, string name, string description, int highestPoint)
    {
        X = x;
        Y = y;
        Name = name;
        Description = description;
        HighestPoint = highestPoint;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Name of object: {Name}");
        Console.WriteLine($"X coordinates: {X}");
        Console.WriteLine($"Y coordinates: {Y}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Highest point of mountain: {HighestPoint}");
    }
}
