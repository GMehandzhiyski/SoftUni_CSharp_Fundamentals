﻿namespace _08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumNumber = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == sumNumber)
                    {
                        Console.WriteLine($"{array[i]} {array[j]}");
                    }


                }

            }

        }
    }
}