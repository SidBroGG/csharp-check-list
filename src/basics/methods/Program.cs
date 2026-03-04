class Program
{
    // Простой метод
    static void printDa()
    {
        Console.WriteLine("da");
    }

    // Разные параметры
    static void changeNum(ref int input, in int increment, out int result)
    {
        // ref - ссылка, можно изменять значение
        // in - ссылка, только для чтения
        // out - выходное значение
        result = input + increment;
    }

    // Множество параметров
    static int sumNums(params int[] nums)
    {
        int result = 0;

        foreach (int num in nums)
        {
            result += num;
        }

        return result;
    }

    // Параметры по умолчанию
    static void printHuman(in string name = "Stas", in int age = 52)
    {
        Console.WriteLine($"Name: {name}\nAge: {age}");
    }

    static void Main()
    {
        printDa();

        int inputNum = 5;
        changeNum(input: ref inputNum, increment: 3, result: out int a);
        Console.WriteLine($"changeNum result: {a}");

        int sumResult = sumNums(1, 2, 3, 4, 5, 6);
        Console.WriteLine($"Sum result: {sumResult}");

        int[] numArr = { 2, 4, 6, 8 };
        Console.WriteLine($"Sum with arr result: {sumNums(numArr)}");

        printHuman();
    }
}

// Модификаторы доступа
// public - везде
// private - только внутри класса
// protected - внутри класса и его наследников
// internal - только внутри проекта
// protected internal - внутри проекта и его наследников
// private protected - наследники внутри проекта