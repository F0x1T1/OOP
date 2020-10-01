using System;

    class Program
    {
        static void Main(string[] args)
        {
        bool Res;
        int x;
        x = int.Parse(Console.ReadLine());

            if((x%9)==0|| (x % 11) == 0|| (x % 13) == 0)
            {
            Res = true;
            }
            else
            {
            Res = false;
            }

        Console.WriteLine(Res);
        Console.ReadKey();

        }
    }

