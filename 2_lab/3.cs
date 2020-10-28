using System;
class Program
    {
        static void Main(string[] args)
        {
        int[] arr = { 1 };
        int suma=0, sumb=0;
        bool fin = false;

        for(int i=1; i<arr.Length-1; i++)
        {
            for(int j=0; j<i; j++)
            {
            suma = suma + arr[j];
            }
            for(int j = i+1; j < arr.Length; j++)
            {
            sumb = sumb + arr[j];
            }
            if (suma == sumb)
            {
            Console.WriteLine("Its : " + i);
            fin = true;
            }
            suma = 0;
            sumb = 0;
        }
        if (arr.Length==1)
        {
        Console.WriteLine("0");
        }
        else
        if (fin== false)
        {
        Console.WriteLine("no");
        }
        Console.ReadKey();

    }
    }

