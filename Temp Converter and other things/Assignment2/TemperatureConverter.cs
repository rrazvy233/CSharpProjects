using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class TemperatureConverter
    {
        //variables and constants
        const int maxCelsius = 100;
        const int maxFarenheit = 212;
        int userInput;
        double Farenheit;
        double Celsius;
        private void intro()
        {
            //intro, not a lot to be commented here
            Console.WriteLine("----------------------------------------\n");
            Console.WriteLine("          Temperature Converter\n");
            Console.WriteLine("----------------------------------------\n");
            Console.WriteLine("Celsius to Fahrenheit  : 1 ");
            Console.WriteLine("Fahrenheit to Celsius  : 2 ");
            Console.WriteLine("Exit  : 0 ");
            Console.WriteLine("----------------------------------------\n");
            //reads input and converts it from string to int
            userInput = Console.Read();
        }
        private void CelsiusToFarenheit()
        {
            Console.Write("Your Choice: 1 \n");
            //loop for displaying degrees in Celsius and their equivalent in Farenheit with interval of 5
            for (Celsius = 0; Celsius <= maxCelsius; Celsius = Celsius + 5)
            {
                Farenheit = 9 / 5.0 * Celsius + 32;
                //rounding to 2 decimal places
                Farenheit = Math.Round(Farenheit, 2);
                Console.WriteLine($"{Celsius, 6:F2} C = {Farenheit, 6:F2} C");
            }
        }
        private void FarenheitToCelsius()
        {
            Console.Write("Your Choice: 2 \n" );
            //loop for Farenheit to Celsius with inteval of 5
            for (Farenheit = 0; Farenheit <= maxFarenheit; Farenheit = Farenheit + 5)
            {
                Celsius = 5 / 9.0 * (Farenheit - 32);
                //rounding to 2 deciman places
                Celsius = Math.Round(Celsius, 2);
                Console.WriteLine($"{Farenheit, 6:F2} F = {Celsius,6:F2} C");
            }
        }
        private bool RunAgain()
        {
            string restart;
            intro();
            restart = Console.ReadLine();
            // restarts if 'y' is entered, it returns false if input is y because of the 'bool done = false' down below 
            if (restart == "0")
                return true;
            else
                return false;
        }
        public void Start()
        {
            
            bool done = false;
            do
            {
                switch (userInput)
                {
                    case '1':
                        CelsiusToFarenheit();
                        break;
                    case '2':
                        FarenheitToCelsius();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;

                }
                done = RunAgain();
            }while (!done);
        }
    }
}
