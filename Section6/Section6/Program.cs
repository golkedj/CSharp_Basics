using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{
    class Program
    {
        /*
         * When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
         *   If no one likes your post, it doesn't display anything.
         *   If only one person likes your post, it displays: [Friend's Name] likes your post.
         *   If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
         *   If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
         *   
         * Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
         * Depending on the number of names provided, display a message based on the above pattern.
         */
        static void Excercise1()
        {
            var names = new List<string>();
            Console.Write("Enter name: ");
            var currentName = Console.ReadLine();
            while (!string.IsNullOrWhiteSpace(currentName))
            {
                names.Add(currentName);
                Console.Write("Enter name: ");
                currentName = Console.ReadLine();
            }

            if (names.Count > 2)
            {
                Console.WriteLine(string.Format("{0}, {1}, and {2} others like your post.", names[0], names[1], (names.Count - 2)));
            }
            else if (names.Count > 1)
            {
                Console.WriteLine(string.Format("{0} and {1} like your post.", names[0], names[1]));
            }
            else if (names.Count > 0)
            {
                Console.WriteLine(string.Format("{0} likes your post.", names[0]));
            }
        }

        /*
         * Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
         * Display the reversed name on the console.
         */
        static void Excercise2()
        {
            Console.Write("Enter name: ");
            var currentName = Console.ReadLine();
            var nameChars = new char[currentName.Length];
            var i = currentName.Length - 1;
            foreach (var ch in currentName)
            {
                nameChars[i] = ch;
                i--;
            }

            Console.WriteLine(nameChars);
        }

        /*
         * Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and 
         * ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
         */
        static void Excercise3()
        {
            var numbers = new int[5];
            while (true)
            {
                Console.WriteLine("Enter 5 unique numbers: ");
                bool repeat = false;
                for (var i = 0; i < 5; i++)
                {
                    Console.Write("Enter a unique number: ");
                    var num = Convert.ToInt32(Console.ReadLine());
                    numbers[i] = num;
                    if (i > 0)
                    {
                        for (var j = i-1; j >= 0; j--)
                        {
                            if (numbers[j] == num)
                            {
                                repeat = true;
                                break;
                            }
                        }
                    }
                    if (repeat)
                    {
                        break;
                    }
                }
                if (!repeat)
                {
                    break;
                }
            }
            Array.Sort(numbers);
            Console.WriteLine("Sorted nubers are: ");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

        }

        /*
         * Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include 
         * duplicates. Display the unique numbers that the user has entered.
         */
        static void Excercise4()
        {
            var numbers = new List<int>();
            while (true)
            {
                Console.Write("Enter number or type Quit: ");
                var input = Convert.ToString(Console.ReadLine());
                if (input == "Quit")
                {
                    break;
                }

                var num = Convert.ToInt32(input);
                if (!numbers.Contains(num))
                {
                    numbers.Add(num);
                }
            }
            numbers.Sort();
            Console.WriteLine("Numbers entered: ");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            
        }

        /*
         * Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is 
         * empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
         */
        static void Excercise5()
        {
            while (true)
            {
                bool valid = true;
                Console.Write("Enter a list of comma seperated numbers: ");
                var numberStrings = new List<string>();
                var numbers = new List<int>();
                var input = Convert.ToString(Console.ReadLine());
                if (!string.IsNullOrWhiteSpace(input))
                {
                    numberStrings = input.Split(',').ToList<string>();
                    if (numberStrings.Count < 5)
                    {
                        valid = false;
                    }
                    else
                    {
                        foreach (var st in numberStrings)
                        {
                            numbers.Add(Convert.ToInt32(st));
                        }
                    }
                }
                else
                {
                    valid = false;
                }
                if (valid == false)
                {
                    continue;
                }
                numbers.Sort();
                Console.WriteLine("Three smallest numbers: {0}, {1}, {2}", numbers[0], numbers[1], numbers[2]);
                break;
            }
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
