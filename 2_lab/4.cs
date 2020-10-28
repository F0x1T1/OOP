using System;
using System.Globalization;
class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("isert A size A = 4 * a : ");
        int a;
        a =4* Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" ");
        int[] array = new int[a];
        int[] x = new int[a / 2];
        int[] n = new int[a / 2];
        int[] SUM = new int[a / 2];
        for(int i=0; i<a; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        for(int i = a/4, j=0; i<=((array.Length-1)-(a/4)); i++, j++)
        {
            x[j] = array[i];
        }
        for(int i=(a/4)-1, j = 0; i>=0; i--, j++)
        {
            n[j] = array[i];
        }
        for (int i=array.Length-1, j=a/4; i> (array.Length - 1) - (a / 4); i--, j++)
        {
            n[j] = array[i];
        }
        Console.WriteLine(" ");
        for (int i=0; i < x.Length; i++)
        {
            Console.Write(x[i] + " ");
        }
        Console.WriteLine(" ");
        for (int i = 0; i < n.Length; i++)
        {
            Console.Write(n[i] + " ");
        }
        Console.WriteLine(" ");
        for (int i = 0; i < SUM.Length; i++)
        {
            SUM[i] = x[i] + n[i];
            Console.Write(SUM[i] + " ");
        }
        Console.ReadKey();
        }
    }

