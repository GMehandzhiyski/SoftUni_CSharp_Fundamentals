﻿namespace _01.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());    
            int fourthNumber = int.Parse(Console.ReadLine());

            int firstSum = (firstNumber + secondNumber);
            int secondSum = firstSum / thirdNumber;
            int thirdSum = secondSum * fourthNumber;

            Console.WriteLine(thirdSum);
        }
    }
}