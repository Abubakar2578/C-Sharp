using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUESTION 1 .......");

            int num1 = 10;
            int num2 = 20;
            Console.WriteLine($"num1 is {num1} and num2 is {num2} .");

            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;


            Console.WriteLine($"num1 is {num1} and num2 is {num2} after swapping.");




        }
    }
}