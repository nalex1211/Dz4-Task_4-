using Dz4_Task_4_interface__;

internal class Program
{
    private static void Main(string[] args)
    {
        string obj, description, name;
        double x, y;

        Console.Write("Enter your geographical object(R-River/M-Mountain): ");
        obj = Console.ReadLine() ?? throw new ArgumentNullException(nameof(obj));

        Console.Write("Enter X and Y coordinates: ");
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter description: ");
        description = Console.ReadLine() ?? throw new ArgumentNullException(nameof(description));

        switch (obj) {
            case "R":
                Console.Write("Enter speed and length of river: ");
                int speed = Convert.ToInt32(Console.ReadLine());
                int length = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter name of river: ");
                name = Console.ReadLine() ?? throw new ArgumentNullException(nameof(name));

                var river = new River(x, y, name, description, length, speed);
                river.GetInfo();
                break;

            case "M":
                Console.Write("Enter the highest point of mountain: ");
                int highestPoint = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter name of mountain: ");
                name = Console.ReadLine() ?? throw new ArgumentNullException(nameof(name));

                var mountain = new Mountain(x, y, name, description, highestPoint);
                mountain.GetInfo();
                break;
        }
    }
}