using System.Runtime;
int loop = 1;

while (loop == 1)
{
    Console.WriteLine("Welcome to the Rectangle Room Detail Geneator!");

    Console.WriteLine("Enter length of room");
    double length = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter width of room");
    double width = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter height of room");
    double height = Convert.ToDouble(Console.ReadLine());

    double perimeter = 2 * (length + width);
    double volume = height * width * length;
    double area = length * width;
    double surfaceArea = 2 * ((length * width) + (length * height) + (height * width));
    string roomSize = string.Empty;

    if (area <= 250)
    {
        roomSize = "small";
    }
    else if (area > 250 && area < 650)
    {
        roomSize = "medium";
    }
    else if (area >= 650)
    {
        roomSize = "large";
    }
    Console.WriteLine($"This is a {roomSize} room, at {length} ft. long, {width} ft. wide, and {height} ft. high");
    Console.WriteLine($"Perimeter: {perimeter} linear ft.");
    Console.WriteLine($"Volume: {volume} cubic ft.");
    Console.WriteLine($"Area: {area} square ft.");
    Console.WriteLine($"Surface area: {surfaceArea} square ft.");

    string playAgain = string.Empty;
    do
    {
        Console.WriteLine("Would you like to enter another room? [y][n]");
        playAgain = Console.ReadLine().ToLower();
        if (playAgain == "y")
        {
            Console.Clear();
            continue;
        }
        else if (playAgain == "n")
        {
            Console.Clear();
            loop = 0;
            Console.WriteLine("Goodbye!");
        }
    } while (playAgain != "y" && playAgain != "n");
}
Console.ReadKey();
