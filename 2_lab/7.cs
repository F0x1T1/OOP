using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            int s = 0, bs = -1;
            int l = 1, bl = -1;
            Console.Write("Input length of array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i < n; i++)
            {
                if (array[i] > array[s]) { l++; }
                else
                {
                    s = i;
                    l = 1;
                }
                if (bl < l)
                {
                    bl = l;
                    bs = s;
                }
            }
            Console.Write($"s={bs} l={bl}\n");
            for (int i = bs; i < bl + bs; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.ReadKey();
        }
    }
}