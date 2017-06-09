using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Conditionals
    {
        /*
         * Write a program and ask the user to enter a number. The number should be between 1 to 10. 
         * If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid". 
         * (This logic is used a lot in applications where values entered into input boxes need to be validated.)
         */
        public static void Excercise1()
        {
            Console.WriteLine("Enter a number: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if ((number >= 1) && (number <= 10))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }

        /*
         * Write a program which takes two numbers from the console and displays the maximum of the two.
         */
        public static void Excercise2()
        {
            Console.WriteLine("Enter first number:");
            var input = Console.ReadLine();
            var number1 = Convert.ToInt32(input);

            Console.WriteLine("Enter second number:");
            input = Console.ReadLine();
            var number2 = Convert.ToInt32(input);

            var maxNumber = (number1 > number2) ? number1 : number2;
            Console.WriteLine("Max number was: " + maxNumber);

        }

        /*
         * Write a program and ask the user to enter the width and height of an image. 
         * Then tell if the image is landscape or portrait.
         */
        public static void Excercise3()
        {
            Console.WriteLine("Enter height:");
            var input = Console.ReadLine();
            var height = Convert.ToInt32(input);

            Console.WriteLine("Enter width:");
            input = Console.ReadLine();
            var width = Convert.ToInt32(input);

            if (height > width)
            {
                Console.WriteLine("Picture was portrait");
            }
            else
            {
                Console.WriteLine("Picture was landscape");
            }
        }

        /*
         * Your job is to write a program for a speed camera. For simplicity, ignore the details such as 
         * camera, sensors, etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. 
         * Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, 
         * program should display Ok on the console. If the value is above the speed limit, the program should 
         * calculate the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be 
         * incurred and displayed on the console. If the number of demerit points is above 12, 
         * the program should display License Suspended.
         */
        public static void Excercise4()
        {
            Console.WriteLine("Enter speed limit: ");
            var input = Console.ReadLine();
            var speedLimit = Convert.ToInt32(input);
            Console.WriteLine("Enter vehicle speed: ");
            input = Console.ReadLine();
            var vehicleSpeed = Convert.ToInt32(input);

            if (speedLimit >= vehicleSpeed)
            {
                Console.WriteLine("OK");
            }
            else
            {
                var demeritPoints = (int)((vehicleSpeed - speedLimit) / 5);
                Console.WriteLine("Number of demerit points = " + demeritPoints);
                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }

            }
            
        }
    }
}
