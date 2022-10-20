namespace Dz4_Task_4_interface__;

internal class Mountain : IGeogObject
{
    private double X;
    private double Y;
    private string Name;
    private string Description;
    private int HighestPoint;

    public Mountain(double x, double y, string name, string description, int highestPoint)
    {
        X = x;
        Y = y;
        Name = name ?? throw new ArgumentNullException(nameof(Name));
        Description = description ?? throw new ArgumentNullException(nameof(Name));
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
