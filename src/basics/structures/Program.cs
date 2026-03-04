class Program
{
    // enum
    enum Day
    {
        Monday,
        Tuesday
    }

    // struct (хранится в стеке)
    struct Point
    {
        public int X;
        public int Y;
        public override readonly string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    // record
    record Person(string Name, int Age);

    static void Main()
    {
        Day today = Day.Monday;
        Console.WriteLine(today == Day.Monday ? "Monday" : "Another day");

        Point p;
        p.X = 52;
        p.Y = 42;
        Console.WriteLine(p.ToString());

        var p1 = new Person("Skibidi", 52);
        var p2 = new Person("Skibidi", 52);
        Console.WriteLine(p1 == p2); // у class был бы falses
    }
}