using System;
 class Program
    {
        static void Main(string[] args)
        {

        int x, n, m;

        x = int.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine());
        m = int.Parse(Console.ReadLine());

        if (n < x && x > m)
        {
            Console.WriteLine(x);
        }
        else
        {
            if(n > x && n > m){
                Console.WriteLine(n);
            }
            else
            {
                if (m > x && m > n)
                {
                    Console.WriteLine(m);
                }
                else
                {
                    Console.WriteLine("Errore");
                }
            }
        }
        Console.ReadKey();
    }
    }

