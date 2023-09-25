using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    public class PhoneBook
    {
        private string[] names = { "John", "Andre", "Fabian", "Mia", "Hammam", "Claude" };
        private string[] phones = { "072649578", "078461326", "071166490", "073132659", "078496316", "074464913" };

        private string[,] phoneList;

        public void DisplayList()
        {
            int lenght = names.Length;
            for (int i = 0; i < lenght; ++i)
            {
                string strOut = string.Format("{0,-15} {1,-15}", names[i], phones[i]);
                Console.WriteLine(strOut);
            }
        }
        public void SortByName()
        {
            int pos, i;
            int length = names.Length;

            for (pos = 0; pos < length - 1; ++pos)
            {

                for (i = 0; i < length - pos - 1; ++i)
                {
                    int result = names[i].CompareTo(names[i + 1]);
                    if (result == 1)
                    {
                        SwapValues(i);
                    }
                }
            }
        }
        public void SwapValues(int pos)
        {
            string temp = names[pos];
            names[pos] = names[pos + 1];
            names[pos + 1] = temp;

            string temp1 = phones[pos];
            phones[pos] = phones[pos + 1];
            phones[pos + 1] = temp1;
        }
        public void FillTable()
        {
            for (int i = 0; i < 6; i++)
            {
                phoneList[i, 0] = names[i];
                phoneList[i, 1] = phones[i];
            }
        }
        public void DisplayTable()
        {
            int rows = phoneList.GetLength(0);
            int cols = phoneList.GetLength(1);

            for (int row = 0; row < rows; row++)
            {

                Console.Write(String.Format("{0,-8}", "Row" + row.ToString()));

                for (int col = 0; col < cols; col++)
                {
                    Console.Write(string.Format("{0,-8}", phoneList[row, col]));
                }
                Console.WriteLine();
            }
        }
        public PhoneBook()
        {
            Console.Clear();
            DisplayList();
            Console.WriteLine();

            SortByName();
            Console.WriteLine("\n\nSortedList:\n");
            DisplayList();

            int count = names.Length;
            phoneList = new string[count, 2];
            FillTable();

            Console.WriteLine("\n\nusing 2d array\n");
            DisplayTable();



        }
    }
}
