using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4C
{
    internal class PartyManager
    {
        private double costPerPerson; //cost per person
        private double feePerPerson; // fees to be paid by each person

        private string[] guestList; //names of guests

        // constructor that exects the max number of guests from MainForm to set size of array
        public PartyManager(int maxNumber)
        {
            //creates the array in this construct
            guestList = new string[maxNumber];
            
        }
        private int GuestNumber()
        {
            //gets the max number of guests
            int guestNum = 0;
            for (int i = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    guestNum++;
                }
            }
            return guestNum;
        }
        public string[] GuestList()
        {
            //creates the array with the given number of guests
            int size = GuestNumber();
            if (size <= 0)
            {
                return null;
            }
            string[] guest = new string[size];

            for (int i = 0, j = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    guest[j++] = guestList[i];
                }
            }
            return guest;
        }
        private int FindPosition()
        {
            //this method finds available positions in the array
            // available positions are those who have an enmpty string
            int noPos = -1; //no position aviable
            for (int index = 0; index < guestList.Length; index++)
            {
                if (string.IsNullOrEmpty(guestList[index]))
                {
                    noPos = index;
                    break;
                }
            }
            return noPos;
        }
        public int ReturnGuestNr()
        {
            //returns the array length for GUI
            int number = guestList.Length;
            return number;
        }
        public bool AddNewGuest(string firstName, string lastName)
        {
            //adds a new guests
            bool ok = true;
            //runs the find position method above
            int position = FindPosition();
            //if position is found then it will fill the string with the forst and last name
            if (position != -1)
            {
                guestList[position] = FullName(firstName, lastName);
            }
            else
            {
                //otherwise it will return false and no name will be added
                ok = false;
            }
            return ok;
        }
        private string FullName(string firstName, string lastName)
        {
            //returns last first and last name as a single string
            return lastName.ToUpper() + ", " + firstName;
        }
        //setters and getters
        #region
        public double GetCost()
        {
            return costPerPerson;
        }
        public double GetFee()
        {
            return feePerPerson;
        }
        public void SetCost(double value)
        {
            if (value >= 0)
            {
                costPerPerson = value;
            }
        }
        public void SetFee(double value)
        {
            if (value >= 0)
            {
                feePerPerson = value;
            }
        }
        #endregion
        public double CalculateCost()
        {
            //calculates cost
            double totalcost = 0.0;
            int yes = 0;
            //loop for looking which index in de array is not populated
            for (int i = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    //if index is populated then it will add one to the variable
                    yes++;
                }
            }
           //returns cost * variable so the GUI dosent calculate the entire cost
           // example if there are 7 spots but only 3 are taken the program will only take the cost for the 3 people instead of all 7
            totalcost = costPerPerson * yes;
            return totalcost;
        }
        public double CalcFee()
        {
            //calculates and returns fee, same as above
            double totalfee = 0.0;
            int yes = 0;
            for (int i = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    yes++;
                }
            }
            totalfee = feePerPerson * yes;
            return totalfee;
        }
        public double CalcSurplus()
        {
            //calculates the surplus by getting the cost and fee from above and substract them
            double totalsurplus = 0.0;
            double cost = CalculateCost();
            double fee = CalcFee();
            totalsurplus = fee - cost;
            return totalsurplus;
        }
        public string GetItemAt(int item)
        {
            //this method takes the index from the listbox and sends back the corresponding array string
            string itemReturn = string.Empty;
            if (item >= 0)
            {
                itemReturn = guestList[item].ToString();
            }
            return itemReturn;
        }
        public bool DeleteAt(int index)
        {
            //method for deleteing a string in array
            bool ok = false;
            if (CheckIndex(index))
            {
                guestList[index] = string.Empty;
                MoveElement(index);
                ok = true;
            }
            return ok;
        }
        public int CheckListForParticipants()
        {
            //current number of populated slots on the array, used by GUI to determine if array is full or not
            int people = 0;
            for (int i = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    people++;
                }
            }
            return people;
        }
        private void MoveElement(int index)
        {
            // after the delete button is pressed the string next string will be moved one place down
            //example if Joe is number 1 and Dan is number 2, deleting Joe will move Dan to number 1
            for (int i = index + 1; i < guestList.Length; i++)
            {
                guestList[i - 1] = guestList[i];
                guestList[i] = string.Empty;
            }
        }
        private bool CheckIndex(int value)
        {
            //for delete button
            //checks if the index value is valid
            bool ok = false;
            if (value > -1)
            {
                ok = true;
            }
            return ok;
        }
        public bool ChangeGuest(string firstName, string lastName, int position)
        {
            //method for changing an entry in the array
            //it gets the pisition from the listbox and then it replaces the old name in said position
            bool ok = true;
            if (position != -1)
            {
                guestList[position] = FullName(firstName, lastName);
            }
            else
            {
                ok = false;
            }
            return ok;
        }
    }
}
