using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Pet
    {
        private string name; //name of pet
        private int age; //age as number
        private bool isFemale; //true if female, false if not female

        public void start()
        {
            Console.WriteLine(); //empty line
            Console.WriteLine("Greetings from the Pet Owner app!");
            Console.WriteLine(); //empty line 2
        }
        public void readAndSavePetData()
        {
            //read name of pet
            Console.WriteLine("What is the name of your pet?");
            name = Console.ReadLine();

            //read age of pet
            Console.WriteLine("what is " + name + "'s age?");
            string textValue = Console.ReadLine();

            //convert string to number
            age = int.Parse(textValue);

            //read value (y/n)
            Console.WriteLine("Is Your pet a female (y/n)?");
            string strGender = Console.ReadLine();
            strGender = strGender.Trim();
            char response = strGender[0];
            if ((response == 'y') || (response == 'Y'))
                 this.isFemale = true;
            else
                 this.isFemale = false;
        }
        public void displayPetInfo()
        {
            //displays the above info and adds good boy/girl bases on (y/n) question above
            string textOut = "++++++++++++++++++++";
            Console.WriteLine(textOut);
            Console.WriteLine("Name: " + name + "\nAge: " + age);
            if (this.isFemale)
            {
                Console.WriteLine(name + " is a good girl!");
            }
            else
            {
                Console.WriteLine(name + " is a good boy!");
            }
            Console.WriteLine(textOut);
        }
    }
}