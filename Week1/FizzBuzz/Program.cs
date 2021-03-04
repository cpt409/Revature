using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            string fizz = "FIZZ";
            string buzz = "BUZZ";
            string fizzBuzz = "FIZZ BUZZ";
            int fizzInt = 3;
            int buzzInt = 5;
            int maxValue = 50;

            System.Console.Write("Enter a maximum value: ");

            


            for(int i = 1; i <= maxValue; i++) {
                if (i % fizzInt == 0)
                    System.Console.WriteLine(fizz);
                else if (i % buzzInt == 0)
                    System.Console.WriteLine(buzz);
                else if (i % fizzInt == 0 && i % buzzInt == 0)
                    System.Console.WriteLine(fizzBuzz);
                else
                    System.Console.WriteLine($"{i}");
            }




        }
    }
}
