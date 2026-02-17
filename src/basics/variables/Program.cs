using System;

class Program
{

    class Person
    {
        public string Name = "";
    }

    struct Point
    {
        public int X;
        public int Y;
        public override string ToString() => $"({X}, {Y})";
    }

    static void Main()
    {
        // Базовые типы
        int baseA = 5;
        double baseB = 3.14;
        char baseC = 'c';

        // Референсные типы
        string refStr = "Skbidi";
        int[] refArr = { 1, 2, 3 };
        var refNum = 5; // var => int

        // Nullable типы
        int? nullNum = null;
        nullNum = 52;

        // Value copy
        int refCopyA = 5;
        int refCopyB = refCopyA; // Копирование значения
        refCopyB++;
        Console.WriteLine($"Reference copy: a = {refCopyA}\t b = {refCopyB}");

        // Reference copy
        var person1 = new Person { Name = "Person 1" };
        var person2 = person1; // Копирование ссылки
        person2.Name = "chmo";
        Console.WriteLine($"Person 1 name: {person1.Name}\nPerson 2 name: {person2.Name}");

        // Struct copy
        Point point1 = new Point { X = 52, Y = 2 };
        Point point2 = point1;
        point2.X = 42;
        Console.WriteLine($"Point1: {point1}\nPoint2: {point2}");

        // Boxing unboxing
        object boxed = baseA; // int -> object
        int unboxed = (int)boxed; // object -> int
        Console.WriteLine($"Boxed value: {boxed}, {boxed.GetType().Name}");
        Console.WriteLine($"Unboxed value: {unboxed}, {unboxed.GetType().Name}");

        // Type convertions
        int typeA = 3;
        double typeB = typeA; // implicit

        double piDouble = 3.14;
        int piInt = (int)piDouble; // explicit
        Console.WriteLine($"Pi from double to int cast: {piInt}");

        // Const
        const double piConst = 3.14;

        // Базовый тип object
        object objA = "text";

    }
}