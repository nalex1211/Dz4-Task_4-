namespace Dz4_Task_4_;

public class River : GeogObject
{
    private double Speed;
    private double Length;

    public River(double speed, double length, double x, double y, string name, string description)
        : base(x, y, name, description)
    {
        Speed = speed;
        Length = length;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Length of river: {Length}");
        Console.WriteLine($"Speed of river: {Speed}");
    }
}
