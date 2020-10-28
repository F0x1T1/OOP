using System;
 class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("intput size of arr : ");
        int x;
        x = Convert.ToInt32(Console.ReadLine());
        int[]y = new int[x];
        int[]z = new int[x];
        int[]S = new int[x];
        Random rnd = new Random();
        for(int i=0; i<x; i++)
        {
            y[i] = rnd.Next(11);
        }
        for (int i = 0; i < y.Length; i++)
        {
            Console.Write(y[i]+" ");// Вивід 1 масиву
        }
        Console.WriteLine(" ");
        int raz = Convert.ToInt32(Console.ReadLine());
        for (int r = 0; r < raz; r++)
        {
                for (int i = 0, j = 1; i < y.Length - 1; i++, j++)
                {
                    if (i == 0)
                    {
                        z[i] = y[y.Length - 1];
                        z[j] = y[i];
                    }
                    else
                    {
                        z[j] = y[i];
                    }
                }
                for (int i = 0; i < S.Length; i++)
                {
                    if (raz != 1)
                    {
                        if (r == 1)
                        {
                            S[i] = y[i] + z[i];
                            Console.Write(S[i] + " ");
                        }
                        else
                        {
                            S[i] = S[i] + z[i];
                            Console.Write(S[i] + " ");
                        }
                    }
                else
                {
                    for (int t = 0; t < z.Length; t++)
                    {
                        Console.Write(z[t] + " ");
                    }
                    break;
                }
                }
                Console.WriteLine(" ");
                for (int i = 0; i < y.Length; i++)
                {
                    y[i] = z[i];
                }
                for (int i =0; i< z.Length; i++)
                {
                    z[i] = 0;
                }
        }
        Console.WriteLine();
        Console.ReadKey();
    }
    }

