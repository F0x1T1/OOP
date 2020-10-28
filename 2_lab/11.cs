using System;
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("isert x size : ");
        int x;
        x =Convert.ToInt32(Console.ReadLine());
        int[] array = new int[x+1];
        for(int i = 1; i<=x; i++)
        {
            array[i] = i;
        }
        Console.WriteLine(" ");
        for(int i = 1; i<x+1; i++)
        {
            if(i!=2)
            if (array[i] %2 ==0)
            {
                array[i] = 0;
            }
            if (i > 8)
            {
                if (array[i] % 3 == 0)
                {
                    array[i] = 0;
                }
                if (array[i] % 5 == 0)
                {
                    array[i] = 0;
                }
                if (array[i] % 7 == 0)
                {
                    array[i] = 0;
                }
            }
        }
        Console.WriteLine(" ");
        for (int i = 1; i < x+1; i++)
        {
            if(array[i]!=0)
            Console.Write(array[i]+" ");
        }
        Console.ReadKey();
    }
    }