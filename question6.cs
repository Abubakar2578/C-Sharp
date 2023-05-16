using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUESTION 6 .......");


            Console.Write("Enter the Character: ");
            char choice = char.Parse(Console.ReadLine().ToUpper());   // convert string to char  // convert to uppercase
            Console.WriteLine(choice);


            switch(choice)
            {
                case 'J':
                Console.WriteLine("January , June , July ");
                break;

                case 'F':
                Console.WriteLine("Febrary");
                break;

                case 'M':
                Console.WriteLine("March , May ");
                break;

                case 'A':
                Console.WriteLine("April , August ");
                break;

                case 'S':
                Console.WriteLine("September ");
                break;

                case 'O':
                Console.WriteLine("October ");
                break;

                case 'D':
                Console.WriteLine("December ");
                break;

                default:
                Console.WriteLine("Enter valid Character:");
                break;

            }




            




        }
    }
}