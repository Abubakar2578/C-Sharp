using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUESTION 3 .......");

            float[] numbers = new float[10];

            for(int i = 0 ; i < 10 ; i++)
            {
                Console.Write($"Enter the value of {i} number: ");
                numbers[i] = (float)Convert.ToDouble(Console.ReadLine());

            }

            float sum = 0, product = 1;

            for(int i = 0 ; i < 10 ; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine($"Sum is {sum}");

            for(int i = 0 ; i < 10 ; i++)
            {
                product = product * numbers[i];
            }
            Console.WriteLine($"Product is {product}");

            
            Console.WriteLine("Square is: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{(numbers[i] * numbers[i])} ");
 
            }
            Console.WriteLine("");

            Console.WriteLine("Difference is : ");

            for (int i = 0; i < 9; i++)
            {
                Console.Write($"{numbers[i + 1] - numbers[i]} ");
            }
            Console.WriteLine("");


            
            




        }
    }
}