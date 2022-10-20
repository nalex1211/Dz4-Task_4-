using Dz4_Task_4_;

internal class Program
{
    private static void Main(string[] args)
    {
        const string riv = "R";
        const string mount = "M";

        Console.Write("Enter your geographical object(R-River/M-Mountain): ");
        string obj = Console.ReadLine() ?? throw new ArgumentNullException(nameof(obj));

        Console.Write("Enter X and Y coordinates: ");
        double x = Convert.ToInt32(Console.ReadLine());
        double y = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter description: ");
        string description = Console.ReadLine() ?? throw new ArgumentNullException(nameof(description));

        switch (obj) {
            case riv:
                Console.Write("Enter speed and length of river: ");
                double speed = Convert.ToInt32(Console.ReadLine());
                double length = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter name of river: ");
                string name = Console.ReadLine() ?? throw new ArgumentNullException(nameof(name));

                var river = new River(speed, length, x, y, name, description);
                river.GetInfo();
                break;

            case mount:
                Console.Write("Enter the highest point of mountain: ");
                double highestPoint = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter name of mountain: ");
                name = Console.ReadLine() ?? throw new ArgumentNullException(nameof(name));

                var mountain = new Mountain(highestPoint, x, y, name, description);
                mountain.GetInfo();
                break;
        }
    }
}