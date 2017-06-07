using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Dave";
            var lastName = "Golke";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);

            var text = @"Hi John
Look into the following paths
c:\folder3\folder4
c:\folder3\folder4";
            Console.WriteLine(text);
        }
    }
}
