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
            


            /////////////////////////////

            Console.WriteLine("QUESTION 2 .......");

            /*
            double s , t , v , a ,vf, u;

            Console.Write("Enter Distance: ");
            s = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Time: ");
            t = Convert.ToDouble(Console.ReadLine());

            v = s/t;
            Console.WriteLine($"Velocity is: {v}");

            a = v / t;
            Console.WriteLine($"Accelration is: {a}");

            Console.Write("Enter Intial velocity: ");
            u = Convert.ToDouble(Console.ReadLine());

            vf = u + (a*t);
            Console.WriteLine($"Final Velocity is: {vf}");


            s= u*t + (a * t * t / 2);
            Console.WriteLine($"Distance is: {s}");

            s = (v * t) - (a *t * t / 2);
            Console.WriteLine($"Distance is: {s}");

            double v2 = (u * u) + (2 * a * s);
            Console.WriteLine($"Final velocity square is: {v2}");

            s = (v + u)*t / 2;
            Console.WriteLine($"Distance is: {s}");
            */




            Console.WriteLine("QUESTION 3 .......");

            /*
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
            */



            Console.WriteLine("QUESTION 4 .......");

            /*

            double voltage , resistance , current , resistanceT , resistance1 , resistance2 ;

            Console.Write("Enter Resistance: ");
            resistance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Current: ");
            current = Convert.ToDouble(Console.ReadLine());

            voltage = resistance * current;

            Console.WriteLine($"Voltage is: {voltage}");

            Console.Write("Enter Resistance 1: ");
            resistance1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Resistance2: ");
            resistance2 = Convert.ToDouble(Console.ReadLine());

            resistanceT = resistance1 + resistance2;

            Console.Write($" Resistance in Series Circuit is: {resistanceT}");

            resistanceT = (1 / resistance1)+ (1 / resistance2);

            Console.Write($" Resistance in Parallel Circuit is: { 1 / resistanceT}");
            */



            Console.WriteLine("QUESTION 5 ......."); 

            /*
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

            */



            Console.WriteLine("QUESTION 6 .......");

            /*
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
            */


            Console.WriteLine("QUESTION 7 .......");

            /*
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
            */

            Console.WriteLine("QUESTION 8 .......");

            /*

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
            */




            Console.WriteLine("QUESTION 9 .......");

            /*
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

            */




            Console.WriteLine("Question 10.......");

            /*
    
            static bool IsPrime(int n) 
            {
                if (n <= 1) return false;
                for (int i = 2; i <= Math.Sqrt(n); i++) {
                    if (n % i == 0) return false;
                }
                return true;
            }

            static void Main(string[] args)
            {
                int[] arr = { 3, 6, 8, 11, 12, 17, 22, 23, 29, 30 };
                int evenCount = 0;
                int oddCount = 0;
                int primeCount = 0;

                foreach (int num in arr)
                {
                    if (num % 2 == 0) 
                    {
                        evenCount++;
                    } 
                    else 
                    {
                        oddCount++;
                    }
                    if (IsPrime(num)) 
                    {
                        primeCount++;
                    }
                }

                Console.WriteLine("Number of even integers: " + evenCount);
                Console.WriteLine("Number of odd integers: " + oddCount);
                Console.WriteLine("Number of prime integers: " + primeCount);
            } 

            */



            Console.WriteLine("QUESTION 11 .......");

            /*

            string input , output;
            int choice , count;
            char ch, replaceCh;

            do
            {
                Console.WriteLine("MENU\n 1- Find length of string\n2. Reverse a string\n3. Convert a string to uppercase\n4. Convert a string to lowercase\n5. Count the number of occurrences of a character in a string\n6. Replace all occurrences of a character in a string with another character\n7. Exit the program")
                Console.Write("Enter Your choice of operation (1 to 7): ");
                choice = int.Parse(Console.ReadLine());


                switch (choice) {

                    case 1:
                        Console.Write("Enter a string: ");
                        input = Console.ReadLine();

                        Console.WriteLine($"Length of the string: {input.Length}");
                        break;



                    case 2:
                        Console.Write("Enter a string: ");
                        input = Console.ReadLine();

                        output = new string(input.Reverse().ToArray());
                        Console.WriteLine($"Reversed string: {output}");

                        break;



                    case 3:
                        Console.Write("Enter a string: ");
                        input = Console.ReadLine();

                        output = input.ToUpper();
                        Console.WriteLine($"Uppercase string: {output}");
                        break;



                    case 4:
                        Console.Write("Enter a string: ");
                        input = Console.ReadLine();


                        output = input.ToLower();
                        Console.WriteLine($"Lowercase string: {output}");
                        break;


                    case 5:

                        Console.Write("Enter a string: ");
                        input = Console.ReadLine();

                        Console.Write("Enter the character to count: ");
                        ch = char.Parse(Console.ReadLine());
                        count = 0;

                        foreach (char c in input) 
                        {
                            if (c == ch) 
                            {
                                count++;
                            }
                        }
                        Console.WriteLine($"Number of occurrences of {ch} : {count}");
                        break;




                    case 6:

                        Console.Write("Enter a string: ");
                        input = Console.ReadLine();

                        Console.Write("Enter the character to replace: ");
                        ch = char.Parse(Console.ReadLine());

                        Console.Write("Enter the replacement character: ");
                        replaceCh = char.Parse(Console.ReadLine());

                        output = input.Replace(ch, replaceCh);
                        Console.WriteLine($"New string: {output}");
                        break;




                    case 7:
                        Console.WriteLine("Exiting the program Now.....");
                        return;



                    default:
                        Console.WriteLine("Invalid choice. Enter valid Choice.");
                        break;
                }

            

            } while (true);

            */





        }
    }
}