using System;
using System.Collections.Generic;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling LastWord function from Utility Class
            Console.WriteLine("Enter the string");
            string inputString = Console.ReadLine();
            Console.WriteLine("Enter the character to perform split");
            char splitChar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the position of the word you want to retrive");
            int position = Convert.ToInt32(Console.ReadLine());
            string outputString=Utility.LastWord(position, inputString, splitChar);
            Console.WriteLine("Output");
            if (outputString.Length == 0)
            {
                Console.WriteLine("Empty string");
            }
            else
            {
                Console.WriteLine(outputString);
            }


            //calling GetPalindrome function from Utility Class
            Console.WriteLine("Enter the no of strings you want to enter.");
            int number = Convert.ToInt32(Console.ReadLine());
            string[] stringArray = new string[number];
            Console.WriteLine($"Enter {number} strings");
            for (int i = 0; i < number; i++)
            {
                stringArray[i] = Console.ReadLine();
            }
            Utility utility = new Utility();
            List<string> outputList = utility.GetPalindromes(stringArray);
            if (outputList.Count == 0)
            {
                Console.WriteLine("No string is palindrome in the list");
            }
            else
            {
                Console.WriteLine("Output");
                foreach (string items in outputList)
                {
                    Console.WriteLine(items);
                }
            }


            //calling temperature convert functions from TempeartureConverter Class
            Console.WriteLine("Enter the temperature in fahrenheit");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Temperature in celsius is " + TemperatureConverter.ConvertToCelsius(fahrenheit));
            Console.WriteLine("Enter the temperature in celsius");
            double celsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Temperature in fahrenheit is " + TemperatureConverter.ConvertToFahrenheit(celsius));
            
        }
    }
}
