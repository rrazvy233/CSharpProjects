using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class SavingCalculator
    {
        double balance = 0.0;// this is the total ammount with interest
        double ammountPaid = 0.0; // ammount paid without interest
        double months = 0.0; 
        double monthlyDeposit = 0.0;
        double interestRate = 0.10;
        double interestEarned = 0.0;
        
        #region setters and getters
        public double GetMoney()
        {
            return monthlyDeposit;
        }
        public void SetMoney(double value)
        {
            if (value >= 0)
            {
                monthlyDeposit = value;
            }
        }
        public double GetMonths()
        {
            return months;
        }
        public void SetMonths(double value)
        {
            if (value >= 0)
            {
                months = value;
            }
        }
        #endregion
        // method to calculate the ammount of money paid (no interest)
        // monthlyDeposit multiplied by the number of months
        public double CalculateSavings()
        {
            ammountPaid = monthlyDeposit * months;
            return ammountPaid;
        }
        //method that calculates the final balance
        // this loop calculate the final balance (with interest)
        //it is done using a loop to calculate and add the monthlyDeposit and interest for each month
        //interest is divided by 12 first so it can be used for months instead of years
        //where InterestEarned = interestRate * balance is the money gained and deposited for a single month
        //and balance += interestEarned + monthlyDeposit is the money gained and deposited for the whole duration period (in months)
        //example  MonthlyDeposit: 1125  Period: 10 years will give an Ammount paid of 135000.00 and a final balance of 230450.60
        //the number of months would be 120 and the interest rate would be 0.00833333333 as mentioned below
        public double CalculateInterest()
        {
            // this is the interest rate per month after dividing 10%(0.10) to 12 giving the number 0.00833333333
            interestRate = interestRate / 12;
            // loop for calculating final balance
            for (int i = 0; i < months; i++)
            {
                interestEarned = interestRate * balance;
                balance += interestEarned + monthlyDeposit;
            }
            return balance;
        }
    }
}
