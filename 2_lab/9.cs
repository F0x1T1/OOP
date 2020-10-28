using System;
class Program
    {
    static void Main(string[] args)
    {
        int[] array = { 1 ,5 ,3 ,4 ,2 };
        int count = 0;
        int S;
        S = Convert.ToInt32(Console.ReadLine());
        for(int i=0; i< array.Length; i++)
        {
            for(int j=0; j < array.Length; j++)
            {
                if (S==array[i] + array[j]||S==array[i]-array[j]||S==array[j]-array[i])
                {
                    count++;
                }
            }
        }
        Console.WriteLine("Number of combin : " + count/2);
        Console.ReadKey();
        }
    }

