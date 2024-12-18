using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int x;
        for (x = 1; x < 100; x++)
        {
            String FizzBuss = "FizzBuss";
            String Fizz = "Fizz";
            String Buzz = "Buzz";
            
            if (x % 3 == 0 && x % 5 != 0)
            {
                Console.WriteLine(Fizz);
            }
            if (x % 5 == 0 && x % 3 != 0)
            {
                Console.WriteLine(Buzz);
            }
            if (x % 3 == 0 && x % 5 == 0)
            {
                Console.WriteLine(FizzBuss);
            }
            else Console.WriteLine(x);
        }
    }
}