using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Please enter your name: ");
            string userInput = Console.ReadLine();
            
            bool isName = true;
            do {
                if (String.IsNullOrWhiteSpace(userInput)){
                    isName = false;
                    System.Console.Write($"\nBad Input.  Please re-enter your name: ");
                    userInput = Console.ReadLine();
                }
                else {
                    isName = true;
                    System.Console.WriteLine($"Hello, {userInput}");
                }
            } while (!isName);
        }
    }
}
