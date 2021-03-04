using System;

namespace UserFizzBuzz
{
    class Program
    {
        static void VerifyOrder(ref int a, ref int b)
        {
            int temp = a;
            if (a > b)
            {
                a = b;
                b = temp;
            }
        }

        static void GetInput(out int val1, out int val2)
        {
            Console.Write("Please enter the start and end values: ");

            bool checkInput = false;

            var line = Console.ReadLine();
            var numbers = line.Split(' ');

            do
            {

                if (numbers.Length < 2 || numbers.Length > 2)
                {
                    Console.Write("\nYou can only enter two numbers.  Please try again: ");
                    checkInput = false;

                    line = Console.ReadLine();
                    numbers = line.Split(' ');

                }
                else
                {

                    checkInput = true;
                }

            } while (!checkInput);

            Int32.TryParse(numbers[0], out val1);
            Int32.TryParse(numbers[1], out val2);

        }

        static void PrintTotals(int ctFz, int ctBz, int ctFzBz)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Totals:\n");
            Console.WriteLine($"Fizz: {ctFz}");
            Console.WriteLine($"Buzz: {ctBz}");
            Console.WriteLine($"FizzBuzz: {ctFzBz}");
        }


        static void Main(string[] args)
        {

            int countStart = 0;
            int countEnd = 0;

            int countFizz = 0;
            int countBuzz = 0;
            int countFizzBuzz = 0;

            int valueFizz = 3;
            int valueBuzz = 5;

            string strFizz = "Fizz";
            string strBuzz = "Buzz";
            string strFizzBuzz = "FizzBuzz";

            GetInput(out countStart, out countEnd);

            VerifyOrder(ref countStart, ref countEnd);


            // process data:
            for (int i = countStart; i <= countEnd; i++)
            {
                if (((i / valueFizz) * valueFizz == i) && ((i / valueBuzz) * valueBuzz == i))
                {
                    Console.WriteLine($"{strFizzBuzz}: {i}");
                    countFizzBuzz++;
                }
                else if ((i / valueFizz) * valueFizz == i)
                {
                    Console.WriteLine($"{strFizz}: {i}");
                    countFizz++;
                }

                else if ((i / valueBuzz) * valueBuzz == i)
                {
                    Console.WriteLine($"{strBuzz}: {i}");
                    countBuzz++;
                }
                else
                    Console.WriteLine(i);
            }



            PrintTotals(countFizz, countBuzz, countFizzBuzz);

            Console.ReadLine();
        }
    }
}
