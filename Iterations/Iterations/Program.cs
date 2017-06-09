using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Program
    {
        /*
         * Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
         * Display the count on the console.
         */
        static void Excercise1()
        {
            var count = 0;

            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count + " numbers are evenly divisible by 3");
        }

        /*
         * Write a program and continuously ask the user to enter a number or "ok" to exit. 
         * Calculate the sum of all the previously entered numbers and display it on the console.
         */
        static void Excercise2()
        {
            var sum = 0;
            while (true)
            {
                Console.Write("Enter a number or 'ok' to exit: ");
                var input = Console.ReadLine();
                if (input != "ok")
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        sum += Convert.ToInt32(input);
                    }
                    continue;
                }
                break;
            }
            Console.WriteLine("Sum of all numbers entered is: " + sum);
        }

        /*
         * Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. 
         * For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
         */
        static void Excercise3()
        {
            while (true)
            {
                Console.Write("Enter a number: ");

                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    continue;
                }

                var number = Convert.ToInt32(input);
                var factorial = 1;
                for (var i = number; i > 0; i--)
                {
                    factorial *= i;
                }

                Console.WriteLine("Factorial is: " + factorial);

                break;
            }
        }

        /*
         * Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
         * If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program 
         * is behaving correctly, you can display the secret number on the console first.)
         */
        static void Excercise4()
        {
            var random = new Random();
            var randomNumber = random.Next(1, 10);
            bool guessedCorrectly = false;

            for (var i = 0; i < 4; i++)
            {
                Console.Write("Guess a number: ");
                var input = Console.ReadLine();
                var guess = Convert.ToInt32(input);


                if (guess == randomNumber)
                {
                    guessedCorrectly = true;
                    break;
                }
            }

            if (guessedCorrectly)
            {
                Console.WriteLine("You won");
            }
            else
            {
                Console.WriteLine("You lost");
            }

        }

        /*
         * Write a program and ask the user to enter a series of numbers separated by comma. 
         * Find the maximum of the numbers and display it on the console. 
         * For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
         */
        static void Excercise5()
        {
            Console.Write("Enter a series of numbers seperated by commas: ");
            var input = Console.ReadLine();
            var inputString = Convert.ToString(input);
            var numberStrings = (inputString).Split(',');
            var numbers = new int[numberStrings.Length];
            var max = 0;

            foreach (var num in numberStrings)
            {
                var currentNumber = Convert.ToInt32(num);
                if (currentNumber > max)
                {
                    max = currentNumber;
                }
            }
            Console.WriteLine("Max number was: " + max);
        }

        static void Main(string[] args)
        {
            Excercise1();
            Excercise2();
            Excercise3();
            Excercise4();
            Excercise5();
        }
    }
}
