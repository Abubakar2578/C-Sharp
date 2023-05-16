using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUESTION 2 .......");

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






            


            

            




        }
    }
}