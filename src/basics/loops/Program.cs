class Program
{
    static void Main()
    {
        // for loop
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine($"For loop iteration: {i}");
        }
        Console.WriteLine();

        // while loop
        int a = 0;
        while (a <= 5)
        {
            Console.WriteLine($"While loop iteration: {a}");
            a++;
        }
        Console.WriteLine();

        // foreach loop
        int[] nums = { 1, 2, 3, 4, 5 };
        foreach (int num in nums)
        {
            Console.WriteLine($"Foreach loop num: {num}");
        }


    }
}