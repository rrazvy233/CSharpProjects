using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Participants
    {
        private string firstName = string.Empty;
        private string lastName = string.Empty;

        private Address address;
        
        public Participants()
        {
            address = new Address();
        }

        public Participants(string firstName, string lastName, Address adres)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            if(adres != null)
            {
                address = adres;
            } else
            {
                address = new Address();
            }
        }
        public Participants(Participants theOther)
        {
            this.firstName = theOther.firstName;
            this.lastName = theOther.lastName;
            this.address = new Address(theOther.address);
        }
        #region properties
        /// <summary>
        /// Getters and setters for address, first name, last name
        /// </summary>
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }

        }
        #endregion
        #region methods
        /// <summary>
        /// method to get the full name and string it accordingly
        /// method to validate if an item has an empty string
        /// method to format the full name to string
        /// </summary>
        /// <returns></returns>
        public string FullName()
        {
            string namefull = firstName + ", " + lastName;
            return namefull;
        }
        public bool Validation()
        {
            bool addressok = address.Validation();
            bool namesok = (!string.IsNullOrEmpty(firstName) && (!string.IsNullOrEmpty(lastName)));
            return addressok && namesok;
        }
        public override string ToString()
        {
            string allInfo = string.Format("{0, -20} {1}", FullName(), address.ToString());
            return allInfo;
        }
        #endregion
    }
}
