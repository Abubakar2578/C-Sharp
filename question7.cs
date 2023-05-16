using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUESTION 7 .......");

            Console.Write("Enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());

            int num, i;

            for (num = 2; num <= n; num++)
            {
                for (i = 2; i < (num / 2); i++)
                {
                    if (num % i == 0)
                    {
                        i = num;
                        break;
                        
                    }
                    
                }

                if (i != num)
                {
                    Console.Write($"{num}  ");
                    
                }
                
            }



        }
    }
}