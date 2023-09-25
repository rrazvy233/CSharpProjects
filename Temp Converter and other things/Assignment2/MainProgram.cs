using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{

    class MainProgram
    {
        private static void ContinueToNextPart()
        {
            string key;
            Console.WriteLine("\nPRESS ENTER TO CONTINUE TO THE NEXT PART");
            Console.WriteLine();
            key = Console.ReadLine();
            if (key == "")
            {
                Console.Clear();
            }
            
        }
        static void Main(string[] args)
        {
            //create and use object of the FunFeatures class
            FunFeatures funfeaturesObj = new FunFeatures();
            funfeaturesObj.Start();
            ContinueToNextPart();

            //create and use object of the MathWork class
            MathWork mathWorkObj = new MathWork();
            mathWorkObj.Start();
            ContinueToNextPart();
           
            //create and use object of the TemperatureConverter class
            TemperatureConverter temperatureConverterObj = new TemperatureConverter();
            temperatureConverterObj.Start();
            

        }
    }
}