namespace Dz4_Task_4_interface__;

internal interface IGeogObject
{
    double X { get; set; }
    double Y { get; set; }
    string Name { get; set; }
    string Description { get; set; }

    public void GetInfo();
}
