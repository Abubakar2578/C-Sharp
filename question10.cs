using System;

class Program {
    static bool IsPrime(int n) {
        if (n <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++) {
            if (n % i == 0) return false;
        }
        return true;
    }

    static void Main(string[] args) {
        int[] arr = { 3, 6, 8, 11, 12, 17, 22, 23, 29, 30 };
        int evenCount = 0;
        int oddCount = 0;
        int primeCount = 0;

        foreach (int num in arr) {
            if (num % 2 == 0) {
                evenCount++;
            } else {
                oddCount++;
            }
            if (IsPrime(num)) {
                primeCount++;
            }
        }

        Console.WriteLine("Number of even integers: " + evenCount);
        Console.WriteLine("Number of odd integers: " + oddCount);
        Console.WriteLine("Number of prime integers: " + primeCount);
    }
}