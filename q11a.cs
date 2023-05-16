using System;

class StringManipulation {
    static void Main() {
        string input, output;
        char ch, replaceCh;
        int choice, count;

        do {
            Console.WriteLine("\nMENU:\n1. Find the length of a string\n2. Reverse a string\n3. Convert a string to uppercase\n4. Convert a string to lowercase\n5. Count the number of occurrences of a character in a string\n6. Replace all occurrences of a character in a string with another character\n7. Exit the program");
            Console.Write("Enter your choice (1-7): ");
            choice = int.Parse(Console.ReadLine());

            switch (choice) {
                case 1:
                    Console.Write("Enter a string: ");
                    input = Console.ReadLine();
                    Console.WriteLine("Length of the string: " + input.Length);
                    break;
                case 2:
                    Console.Write("Enter a string: ");
                    input = Console.ReadLine();
                    output = new string(input.Reverse().ToArray());
                    Console.WriteLine("Reversed string: " + output);
                    break;
                case 3:
                    Console.Write("Enter a string: ");
                    input = Console.ReadLine();
                    output = input.ToUpper();
                    Console.WriteLine("Uppercase string: " + output);
                    break;
                case 4:
                    Console.Write("Enter a string: ");
                    input = Console.ReadLine();
                    output = input.ToLower();
                    Console.WriteLine("Lowercase string: " + output);
                    break;
                case 5:
                    Console.Write("Enter a string: ");
                    input = Console.ReadLine();
                    Console.Write("Enter the character to count: ");
                    ch = char.Parse(Console.ReadLine());
                    count = 0;
                    foreach (char c in input) {
                        if (c == ch) {
                            count++;
                        }
                    }
                    Console.WriteLine("Number of occurrences of " + ch + ": " + count);
                    break;
                case 6:
                    Console.Write("Enter a string: ");
                    input = Console.ReadLine();
                    Console.Write("Enter the character to replace: ");
                    ch = char.Parse(Console.ReadLine());
                    Console.Write("Enter the replacement character: ");
                    replaceCh = char.Parse(Console.ReadLine());
                    output = input.Replace(ch, replaceCh);
                    Console.WriteLine("New string: " + output);
                    break;
                case 7:
                    Console.WriteLine("Exiting the program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (true);
    }
}
