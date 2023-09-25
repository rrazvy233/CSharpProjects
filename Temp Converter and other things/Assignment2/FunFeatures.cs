using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class FunFeatures
    {
        private string lastname = "";
        private string name = "";
        private string email = "";

        private void Introduce()
        {
            //introduction info
            Console.WriteLine("My name is Razvan and i am a student of Malmö University");
            Console.WriteLine();
            Console.WriteLine("\nLet me know about yourself!");
            //read name
            Console.Write("Your first name: ");
            name = Console.ReadLine();
            Console.Write("Your last name: ");
            lastname = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + name + "!");
            //ask and read email
            Console.Write("Please enter your email: ");
            email = Console.ReadLine();
            // dispaly info and convert lastname to upper case
            Console.WriteLine("Here is your full name and your email");
            lastname = lastname.ToUpper();
            Console.WriteLine(lastname + ", " + name + " " + email);
        }
        private void PredictTheDay()
        {
            int day = 0;
            //intro fortune teller and read day
            Console.Write("I am a fortune teller." + "\nSelect a number between 1 and 7: ");
            day = Convert.ToInt32(Console.ReadLine());
            //display text based on day selected above
            switch (day)
            {
                //example, if day input is 1, case 1 will run
                case 1:
                    Console.WriteLine("Monday: Keep calm my friend! You can fall apart!");
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("Tuesday and Wednesday break your heart!");
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Tuesday and Wednesday break your heart!");
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine("Thursday, OMG, still one day to Friday!");
                    Console.WriteLine();
                    break;
                case 5:
                    Console.WriteLine("It's Friday! You are in love!");
                    Console.WriteLine();
                    break;
                case 6:
                    Console.WriteLine("Saturday, do nothing and do plenty of it!");
                    Console.WriteLine();
                    break;
                case 7:
                    Console.WriteLine("And Sunday always comes too soon!");
                    Console.WriteLine();
                    break;
            }
            //if statement that displays an error when the number is invalid
            if (1 < day && day > 7)
            {
                Console.WriteLine("Please enter a number between 1 and 7.");
                Console.WriteLine();
            }
        }
        private void LineStrength()
        {
            string text;
            string textToUpper;
            //intro
            Console.WriteLine("Length of a text: Write a text of any number of characters and press Enter.");
            Console.WriteLine("I will calculcate the number of characters in the text.");
            Console.WriteLine("Please enter your text here: ");
            text = Console.ReadLine();
            //text to upper case
            textToUpper = text.ToUpper();
            //display text to upper and number of characters at the end
            Console.WriteLine(textToUpper + " = " + text.Length);
        }
        private bool RunAgain()
        {
            string restart;
            Console.WriteLine("Do you wish to run again?  (y/n)");
            restart = Console.ReadLine();
            // restarts if 'y' is entered, it returns false if input is y because of the 'bool done = false' down below 
            if (restart == "y")
                return false;
            else
                return true;
        }
        public void Start()
        {
            Introduce();
            //do-while loop to run method 2, 3 and 4 again
            bool done = false;
            do
            {
                PredictTheDay();
                LineStrength();
                done = RunAgain();
            } while (!done);
            //displays message and inserted name if the program is ran again
            if (done == false)
            {
                Console.WriteLine();
                Console.WriteLine("Welcome back, " + name);
            }
        }       
    }
}