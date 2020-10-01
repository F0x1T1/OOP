using System;

    class Program
    {
        static void Main(string[] args)
        {
        int n;
        Boolean Result;

        n = int.Parse(Console.ReadLine());

        if (n > 20 && (n % 10) == 1)
        {
            Result = true;
            Console.WriteLine(Result);
        }
        else
        {
            Result = false;
            Console.WriteLine(Result);
        }
        Console.ReadKey();
        }
    }

