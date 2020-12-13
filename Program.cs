using System;

namespace FizzBuzz
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            FizzBuzzChallenge Fizz = new FizzBuzzChallenge();
            Console.WriteLine(Fizz.FizzBuzz());
        }
    }

    class FizzBuzzChallenge
    {
        public string FizzBuzz()
        {
            while (true)
            {
                Console.Write("Please provide me with a number: ");
                int number;

                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Please input number");
                    Console.Write("Please provide me with a number: ");
                }

                if ((number % 3 == 0) && (number % 5 == 0))
                {
                    return "FizzBuzz";
                }

                else if (number % 3 == 0)
                {
                    return "Fizz";
                }

                else if (number % 5 == 0)
                {
                    return "Buzz";
                }

                else
                {
                    return number.ToString();
                }
            }
        }
    }
        
}
