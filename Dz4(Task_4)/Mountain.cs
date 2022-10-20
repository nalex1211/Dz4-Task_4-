namespace Dz4_Task_4_;

public class Mountain : GeogObject
{
    private double HighestPoint;

    public Mountain(double highestPoint, double x, double y, string name, string description)
        : base(x, y, name, description)
    {
        HighestPoint = highestPoint;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Highest point: {HighestPoint}");
    }
}
