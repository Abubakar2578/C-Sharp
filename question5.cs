using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUESTION 5 ......."); 
            decimal marks;

            
            
            

            do
            {
                
                Console.Write("Enter Your Marks: ");
                marks = (decimal)Convert.ToDouble(Console.ReadLine());
                
            } while (marks <= 0 && marks >= 100);


            if(marks > 89)
            {
                Console.WriteLine("Your Grade is 'A+' ");
            }
            else if(marks > 79 && marks <= 89)
            {
                Console.WriteLine("Your Grade is 'A' ");

            }
            else if(marks > 69 && marks <= 79)
            {
                Console.WriteLine("Your Grade is 'B' ");

            }
            else if(marks > 59 && marks <= 69)
            {
                Console.WriteLine("Your Grade is 'C' ");

            }
            else if(marks > 49 && marks <= 59)
            {
                Console.WriteLine("Your Grade is 'D' ");

            }
            else
            {
                Console.WriteLine("Your grade is 'F' ");
            }




        }
    }
}