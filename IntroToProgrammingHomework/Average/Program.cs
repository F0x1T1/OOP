using System;
    class Program
    {
        static void Main(string[] args)
            {
        float x, n, m;
        
        x = int.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine());
        m = int.Parse(Console.ReadLine());
        float avrag = (x + n + m) / 3;

        Console.WriteLine(avrag);
        Console.ReadKey();
    }
    }

