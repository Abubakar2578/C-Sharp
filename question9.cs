using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUESTION 9 .......");

            
            int[] arr = { 16, 17, 4, 3, 5, 2 };
            int size = arr.Length;

            int maxFromRight = arr[size - 1];

            Console.Write($"Leaders: {maxFromRight} ");

            for (int i = size - 2; i >= 0; i--)
            {
                if (arr[i] > maxFromRight)
                {
                    maxFromRight = arr[i];
                    Console.Write($"{maxFromRight} ");
                }
                
            }

            Console.WriteLine("");


            




        }
    }
}