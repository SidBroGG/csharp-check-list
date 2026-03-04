class Program
{
    static void Main()
    {
        // if / ifelse / else construction
        Console.Write("Enter number: ");
        string input = Console.ReadLine();

        int a;
        if (int.TryParse(input, out a))
        {
            if (a > 0)
            {
                Console.WriteLine("Positive number");
            }
            else if (a == 0)
            {
                Console.WriteLine("Number equals zero");
            }
            else
            {
                Console.WriteLine("Negative number");
            }
        }
        else
        {
            Console.WriteLine("It is not a number");
        }

        // Ternary operator
        int numB = a > 0 ? 1 : -1;
        Console.WriteLine($"Num b: {numB}");

        // Switch
        int day = 1;

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            default:
                Console.WriteLine("Unknown day");
                break;
        }

        // Modern switch
        string dayName = day switch
        {
            1 => "Monday",
            2 => "Tuesday",
            _ => "Unknown" // default replacement
        };
        Console.WriteLine("Modern switch: " + dayName);

        // Pattern matching
        object obj = 5;
        if (obj is int number)
        {
            Console.WriteLine("Object is Number: " + number.ToString());
        }

        // Switch with arguments
        object value = 13;

        switch (value)
        {
            case int n when n > 10:
                Console.WriteLine("Number > 10: " + n.ToString());
                break;
            default:
                Console.WriteLine("Unknown type");
                break;
        }

        // Null checking
        string? name = "qwerty";

        if (name != null && name is not null)
        {
            Console.WriteLine("Not null");
        }
    }
}