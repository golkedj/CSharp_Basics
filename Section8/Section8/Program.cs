﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Lecture 63 */
            /*var fullName = "Dave Golke ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            Console.WriteLine(fullName.Replace("Dave", "David"));

            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));*/

            /* Lecture 64 */
            /*var sentence = "This is going to be a really really really really really long text.";
            var summary = StringUtility.SummerizeText(sentence, 25);
            Console.WriteLine(summary);*/

            /* Lecture 65 */
            /*var builder = new StringBuilder("Hello World");

            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            Console.WriteLine("First Char: " + builder[0]);*/

            /* Lecture 67 */
            Exercises.Exercise1();
            Exercises.Exercise2();
            Exercises.Exercise3();
            Exercises.Exercise4();
            Exercises.Exercise5();

            /* Lecture 68 */
            /*Console.Write("What's your name? ");
            var name = Console.ReadLine();

            Console.WriteLine("Reversed name: " + ReverseName(name));

            var numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number (or 'Quit' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                numbers.Add(Convert.ToInt32(input));
            }

            Console.WriteLine("Unique Numbers:");
            foreach (var number in GetUniqueNumbers(numbers))
            {
                Console.WriteLine(number);
            }*/
        }

        public static List<int> GetUniqueNumbers(List<int> numbers)
        {
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                {
                    uniques.Add(number);
                }
            }

            return uniques;
        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
            {
                array[name.Length - i] = name[i - 1];
            }

            return new string(array);
        }
    }
}
