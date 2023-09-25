using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class MathWork
    {
        int startNum;
        int endNum;
        private int SumberNumbers()
        {
            
            //read start and end number
            Console.WriteLine("Please enter a starting number: ");
            startNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the end number: ");
            endNum = Convert.ToInt32(Console.ReadLine());
            
            //if statement to swap the numbers if end is smaller than start
            if (startNum > endNum)
            {
                (startNum, endNum) = (endNum, startNum);
            }
            SumNumbers(startNum, endNum);
            return startNum + endNum;

        }
        private void SumNumbers(int startNum, int endNum)
        {
            int sum = 0;
            //for loop to add the numbers in between start and end number
            for (int i = startNum; i <= endNum; i++)
            {
                sum += i;
            }
            Console.WriteLine("The sum of the numbers between " + startNum + " and " + endNum + " is: " + sum);
        }
        private void PrintEvenNumbers(int startNum, int endNum)
        {
            int i;
            Console.WriteLine("Even numbers between " + startNum + " and " + endNum);
            //basically same loop from above but instead of sum, it types out the numbers between startNum and endNum that are dividable by 2
            for (i = startNum; i <= endNum; i++)
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
        }
        private void MultiplicationTable()
        {
            Console.WriteLine("+++++++++++++++++++ Multiplication table +++++++++++++++++++");
            int row;
            int col;
            //loop for putting out rows limited to 12
            for (row = 1; row <= 12; row++)
            {
                Console.Write("\n");
                //prints out columns and limits them to 12
                for (col = 1; col <= 12; col++)
                {
                    Console.Write(string.Format("{0,4:d} ", row * col));
                }
            }
            Console.WriteLine("\n");
        }
        private void CalculateSquareRoot()
        {
            Console.WriteLine("\nCalculate square root");
            int rows = 0;
            int cols = 0;
            Console.WriteLine("Enter number of rows");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of colons");
            cols = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("\n");
                for (int k = 0; k < cols; k++)
                {
                    Console.Write(Math.Sqrt(k * i) + " ");
                }

            }
            Console.WriteLine();
        }
        private bool RunAgain()
        {
            string restart;
            Console.WriteLine("\nExit calculations?  (y/n)");
            restart = Console.ReadLine();
            // restarts if 'y' is entered, it returns false if input is y because of the 'bool done = false' down below 
            if (restart == "y")
                return true;
            else
                return false;
        }
        public void Start()
        {
            Console.WriteLine("Sum numers between any two numbers!");

            bool done = false;
            do
            {
                SumberNumbers();
                PrintEvenNumbers(startNum, endNum);
                done = RunAgain();
            } while (!done);
            CalculateSquareRoot();
            MultiplicationTable();

        }

    }
}
