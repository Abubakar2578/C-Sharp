using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUESTION 8 .......");

            for (int i = 0; i < 5 ; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("* "); 
                }
                Console.WriteLine("");
                
            }

            Console.WriteLine("");

            int a = 1;

            for (int i = 0; i < 5 ; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write($"{a++} "); 
                }
                Console.WriteLine("");
                
            }

            Console.WriteLine("");

            for (int i = 0; i < 5 ; i++)
            {
                int b = 1;
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write($"{b++} " ); 
                }
                Console.WriteLine("");
                
            }

            Console.WriteLine("");

            int alphabet = 65;

            for (int i = 0; i < 5 ; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write($"{(char)alphabet++} "); 
                }
                Console.WriteLine("");
                
            }

            Console.WriteLine("");

            for (int i = 5; i > 0 ; i--)
            {
                for (int j = i; j > 0 ; j--)
                {
                    Console.Write("* "); 
                }
                Console.WriteLine("");
                
            }
            




        }
    }
}