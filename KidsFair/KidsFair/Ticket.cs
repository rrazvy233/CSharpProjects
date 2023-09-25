using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Ticket
    {
        private string recipientName; // name of the recipient
        private int kid; // child ticket
        private int adult; // adult ticket
        private double payAmmount; // ammount to pay for adilt and child

        public void start()
        {
            Console.WriteLine(@"Welcome to Kids Fair" + 
                "\nChildren get a 75% discount!");

            Console.WriteLine("Please enter your name");
            recipientName = Console.ReadLine();

            // reads the number of adults and children
            double price = 100;
            Console.WriteLine("Ammount of adults: ");
            var adult = Console.ReadLine();
            var numberOfAdults = 0;
            if (adult != null) numberOfAdults = int.Parse(adult);

            Console.WriteLine("Ammount of children: ");
            var child = Console.ReadLine();
            var numberOfChild = int.Parse(child);
            if (child != null) numberOfChild= int.Parse(child);

            //calculates the price of tickets for kids and adults and displays receipt
            double ticketPrice = numberOfAdults * price + numberOfChild * price * 0.25;
            Console.WriteLine(@"+++ Your receipt +++" + 
                "\n+++ Ammount to pay: " + ticketPrice + "\nThank you for your purchase");
        }
            
    }
}