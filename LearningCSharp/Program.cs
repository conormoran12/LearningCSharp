using System;

namespace TemperatureContainer
{
    class Program
    {
        static void Main(string[] args)
        {
            string UsersAnswer = PromptUser(true);
             if (UsersAnswer.ToLower() == "c" || UsersAnswer.ToLower() == "celcius")
             {
                Console.WriteLine("Celcius is temperature type (Celcius to Fahrenheit Conversion)");
                PromptUser(false, "c");
             } else if (UsersAnswer.ToLower() == "f" || UsersAnswer.ToLower() == "fahrenheit")
             {
                Console.WriteLine("Fahrenheit is temperature type (Fahrenheit to Celcius Conversion)");
                PromptUser(false, "f");
            }
            else
            {
                Console.WriteLine("Not a valid temperature type");
                PromptUser(true);
            }
        }



        public static string PromptUser(bool isType, params string[] type)
        {
            if (isType)
            {
                Console.WriteLine("Enter a temperature type: ");
                return Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Enter temperature you want to convert ");
                TemperatureConverter(type[0], Console.ReadLine());
            }
            return "Is a number";
        }

        public static void TemperatureConverter(string tempType, string numToConvert)
        {
            int convertedNumber;

            if (int.TryParse(numToConvert, out var result))
            {
                convertedNumber = result;
            }
            else
            {
                Console.WriteLine("Invalid data type or number");
                PromptUser(false, tempType);
                return;
            }

            if (tempType == "c")
            {
                Console.WriteLine($"{numToConvert} °C is equal to:\n{(convertedNumber * 9/5) + 32} °F");
            }
            else if (tempType == "f")
            {
                Console.WriteLine($"{numToConvert} °F is equal to:\n{(convertedNumber - 32) * 5/9} °C");
            }
        }
    }
}