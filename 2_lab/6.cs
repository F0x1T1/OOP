using System;
class Program
{
    static void Main(string[] args)
    {
        int[] array = { 3, 2, 3, 4, 2, 2, 4 };
        int l = 1;
        int bestl = l;
        int value = 0, bestvalue = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                l++;
                value = array[i];
                if (l > bestl)
                bestvalue = value;
            }
            else
            {
                if (l > bestl)
                {
                    bestvalue = value;
                    bestl = l;
                    l = 1;
                    value = 0;
                }
                else
                {
                    l = 1;
                }
            }
        }
        Console.WriteLine("Best l : " + bestl + " " + "Best value : " + bestvalue);
        Console.WriteLine("");
        if (bestl == 1)
        {
            for (int i = 0; i < l; i++)
            {
                Console.Write(bestvalue + " ");
            }
        }
        else
        {
            for (int i = 0; i < bestl; i++)
            {
                Console.Write(bestvalue + " ");
            }
        }
        Console.ReadKey();
    }
}