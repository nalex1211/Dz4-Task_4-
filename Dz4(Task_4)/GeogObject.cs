namespace Dz4_Task_4_;

public abstract class GeogObject
{
    private double X;
    private double Y;
    private string Name;
    private string Description;
    //private string InfoMethod;

    public GeogObject(double x, double y, string name, string description)
    {
        X = x;
        Y = y;
        Name = name;
        Description = description;
    }

    public virtual void GetInfo()
    {
        Console.WriteLine($"Name of object: {Name}");
        Console.WriteLine($"X coordinates: {X}");
        Console.WriteLine($"Y coordinates: {Y}");
        Console.WriteLine($"Description: {Description}");
    }
}
