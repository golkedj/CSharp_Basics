using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section8
{
    class Exercises
    {
        /* 1- Write a program and ask the user to enter a few numbers separated by a hyphen. 
         * Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" 
         * or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive". */
        public static void Exercise1()
        {
            
            Console.Write("Enter numbers seperated by hyphens: ");
            var inputString = Console.ReadLine();

            
            if (IsConsecutive(inputString))
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }

        }

        public static bool IsConsecutive(string inputString)
        {
            var numberChars = inputString.Split('-');

            var numbers = new List<int>();

            foreach (var number in numberChars)
            {
                numbers.Add(Convert.ToInt32(number));
            }

            // Ascending
            var consecutive = true;
            if (numbers[0] == numbers[1] - 1)
            {
                for (var i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] != (numbers[i + 1] - 1))
                    {
                        consecutive = false;
                    }
                }
            }
            else
            {
                for (var i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] != (numbers[i + 1] + 1))
                    {
                        consecutive = false;
                    }
                }
            }

            return consecutive;
        }

        /* 2- Write a program and ask the user to enter a few numbers separated by a hyphen. 
         * If the user simply presses Enter, without supplying an input, exit immediately; 
         * otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console. */
        public static void Exercise2()
        {
            Console.Write("Enter numbers seperated by hyphens: ");
            var inputString = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(inputString))
            {
                if (ContainsDuplicates(inputString))
                {
                    Console.WriteLine("Duplicate");
                }
                else
                {
                    Console.WriteLine("No Duplicates");
                }
            }

        }

        public static bool ContainsDuplicates(string inputString)
        {
            var numberChars = inputString.Split('-');

            var numbers = new List<int>();

            foreach (var number in numberChars)
            {
                numbers.Add(Convert.ToInt32(number));
            }

            var duplicate = false;

            for (var i = 0; i < (numbers.Count - 1); i++)
            {
                for (var j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        duplicate = true;
                        break;
                    }
                }
                if (duplicate)
                {
                    break;
                }
            }

            return duplicate;
        }

        /* 3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
         * A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display 
         * "Invalid Time". If the user doesn't provide any values, consider it as invalid time. */
        public static void Exercise3()
        {
            Console.Write("Enter a time value in the 24-hour time format (e.g. 19:00): ");
            var inputString = Console.ReadLine();
            var valid = true;
            if (String.IsNullOrWhiteSpace(inputString))
            {
                valid = false;
            }
            else
            {
                valid = IsValidTime(inputString);
            }

            if (valid)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }


        }

        public static bool IsValidTime(string inputString)
        {
            const int hours = 0;
            const int minutes = 1;
            var timeSegs = inputString.Split(':');
            var timeSegNums = new int[2];

            timeSegNums[hours] = Convert.ToInt32(timeSegs[hours]);
            timeSegNums[minutes] = Convert.ToInt32(timeSegs[minutes]);

            if (!(((timeSegNums[hours] >= 0) && (timeSegNums[minutes] >= 0)) &&
                ((timeSegNums[hours] <= 23) && (timeSegNums[minutes] <= 59))))
            {
                return false;
            }
            return true;

        }

        /* 4- Write a program and ask the user to enter a few words separated by a space. Use the words to 
         * create a variable name with PascalCase. For example, if the user types: "number of students", 
         * display "NumberOfStudents". Make sure that the program is not dependent on the input. So, if 
         * the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents". */
        public static void Exercise4()
        {
            Console.Write("Enter a few words separated by spaces: ");
            var inputString = Convert.ToString(Console.ReadLine());
            Console.WriteLine("PascalString: " + ConvertToPascal(inputString));
        }

        public static string ConvertToPascal(string inputString)
        {
            var words = inputString.Split(' ');
            var pascalString = new StringBuilder();
            foreach (var word in words)
            {
                pascalString.Append(word.ToString().Substring(0, 1).ToUpper());
                pascalString.Append(word.ToString().ToLower().Substring(1, word.ToString().Length - 1));
            }

            return pascalString.ToString();
        }

        /* 5- Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the 
         * word. So, if the user enters "inadequate", the program should display 6 on the console. */
        public static void Exercise5()
        {
            Console.Write("Enter a word in English: ");
            var inputString = Console.ReadLine();

            Console.WriteLine("Number of vowels was: " + CountVowels(inputString));
        }

        public static int CountVowels(string inputString)
        {
            var vowels = 0;
            foreach (var ch in inputString.ToLower())
            {
                switch (ch)
                {
                    case 'a':
                    case 'e':
                    case 'o':
                    case 'u':
                    case 'i':
                        vowels++;
                        break;
                    default:
                        break;
                }
            }

            return vowels;
        }
    }
}
