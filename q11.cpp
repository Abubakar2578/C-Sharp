#include <iostream>
#include <string>
#include <algorithm>
using namespace std;

int main() {
    string input, output;
    char ch, replace_ch;
    int choice, count = 0;

    do {
        cout << "\nMENU:\n1. Find the length of a string\n2. Reverse a string\n3. Convert a string to uppercase\n4. Convert a string to lowercase\n5. Count the number of occurrences of a character in a string\n6. Replace all occurrences of a character in a string with another character\n7. Exit the program\nEnter your choice (1-7): ";
        cin >> choice;

        switch (choice) {
            case 1:
                cout << "Enter a string: ";
                cin >> input;
                cout << "Length of the string: " << input.length() << endl;
                break;
            case 2:
                cout << "Enter a string: ";
                cin >> input;
                output = input;
                reverse(output.begin(), output.end());
                cout << "Reversed string: " << output << endl;
                break;
            case 3:
                cout << "Enter a string: ";
                cin >> input;
                transform(input.begin(), input.end(), input.begin(), ::toupper);
                cout << "Uppercase string: " << input << endl;
                break;
            case 4:
                cout << "Enter a string: ";
                cin >> input;
                transform(input.begin(), input.end(), input.begin(), ::tolower);
                cout << "Lowercase string: " << input << endl;
                break;
            case 5:
                cout << "Enter a string: ";
                cin >> input;
                cout << "Enter the character to count: ";
                cin >> ch;
                for (char c : input) {
                    if (c == ch) {
                        count++;
                    }
                }
                cout << "Number of occurrences of " << ch << ": " << count << endl;
                break;
            case 6:
                cout << "Enter a string: ";
                cin >> input;
                cout << "Enter the character to replace: ";
                cin >> ch;
                cout << "Enter the replacement character: ";
                cin >> replace_ch;
                replace(input.begin(), input.end(), ch, replace_ch);
                cout << "New string: " << input << endl;
                break;
            case 7:
                cout << "Exiting the program...\n";
                return 0;
            default:
                cout << "Invalid choice. Please try again.\n";
        }
    } while (true);
}
