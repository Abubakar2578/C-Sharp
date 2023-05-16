using System;

namespace MyApplication
{
    class Prgram
    {
        static public void Main(string[] args)
        {
            string HelloWolrd = "Hello World";
            Console.WriteLine(HelloWolrd);

            string fname = "Abubakar ";
            string lname = "Khalid ";
            string fullname = fname + lname;

            Console.WriteLine(fullname);


            int myNum = 25;
            Console.WriteLine(myNum);

            int num = 5;
            double myDouble = 3.141;
            char  myChar = 'p';
            bool flag = true;
            string hello = "Helloa";

            Console.WriteLine(myDouble);
            Console.WriteLine(flag);

            // explicit type conversion

            int intTest = 100;
            double doubleTest = 5.25;

            bool boolTest = true;

            Console.WriteLine(Convert.ToString(intTest));
            Console.WriteLine(Convert.ToDouble(intTest));
            Console.WriteLine(Convert.ToInt32(doubleTest) );
            Console.WriteLine(Convert.ToString(boolTest));


            Console.WriteLine("....................");

            double val1 = 0.1;
            double val2 = 0.2;

            if (val1 + val2 == 0.3)
            {
                Console.WriteLine($"{val1} + {val2} is equal to 0.3");
                
            }
            else
            {
                Console.WriteLine($"{val1}+{val2} is not equals to 0.3");// this will display
            }

            Console.WriteLine("....................");


            decimal v1 = 0.1M;
            decimal v2 = 0.2M;

            if(v1 + v2 == 0.3M)
            {
                Console.WriteLine($"{v1}+{v2} is equal to 0.3");

            }
            else
            {
                Console.WriteLine($"{v1}+{v2} is not equal to 0.3");
            }

            int valueOfThisVariablecannotBeNull = 4;
            int? valueOfThisVariablecanBeNull = null;

            // int? is used for that variable whose value may assignn null

            Console.WriteLine("....................");

            object obj1 = 1000;
            object obj2 = "This is a string";
            object obj3 = 2.55;

            // object is special data type , can store any datatype

            string abc = "ABUBAKAR";
            Console.WriteLine($"Abubakar lenth is = {abc.Length}") ;

            Console.WriteLine(obj2.ToString().Length);

            Console.WriteLine("obect type is: " + obj2); // this will display the object data type
            Console.WriteLine("....................");

            // dynamic type

            // all things are checked on run time.


            dynamic dynType = "Check Dynamic Type";
            int dynTypeLen = dynType.Length;

            Console.WriteLine("Dynamic type lenth is: " + dynTypeLen +  " " + dynType);

            // Array....................................

            Console.WriteLine("....................");

            String[] myArray = new String[3];
            myArray[0] =  "Pakistan";
            myArray[1] = "India";
            myArray[2] = "China";

            for(int i = 0 ; i < 3 ; i++){
                Console.WriteLine(myArray[i]);
            }  



            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your name: ");
            String username = Console.ReadLine();

            Console.WriteLine("Your name is " + username);


            Console.WriteLine("Your age is: " + age);

            /// formating out puts

            Console.WriteLine(
                format:"{0} is number 1 in Array after pakistan, {1} is at number 2 after china {2} is at number 3",
                arg0: myArray[0],
                arg1: myArray[1],
                arg2: myArray[2]
            );




            int userInput;
            Console.Write("Input using Read() - ");
            userInput = Console.Read();
            Console.WriteLine("ASCII value = {0}" ,userInput);

            Console.ReadKey();





            


        }
    }
}