using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Address
    {
        private string street;
        private string city;
        private string zipCode;
        private Countries country;
        
        public Address(string street, string zip, string city, Countries country)
        {
            this.street = street;
            this.zipCode = zip;
            this.city = city;
            this.country = country;
        }
        public Address(string street, string zip, string city) :

            this(street, zip, city, Countries.Sverige)
        { }
        public Address() : this(string.Empty, string.Empty, string.Empty)
        {

        }
        public Address(Address theOther)
        {
            this.street = theOther.street;
            this.zipCode = theOther.zipCode;
            this.city = theOther.city;
            this.country = theOther.country;
        }
        #region properties
        /// <summary>
        /// gets and sets street, zip code, city and country
        /// </summary>
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
        public string City
        {
            get { return city; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    city = value;
            }
        }
        public Countries Country
        {
            get { return country; }
            set
            {
                country = value;
            }
        }
        #endregion
        #region methods
        /// <summary>
        /// gets country and replaces _ with space
        /// valdates that city is not null or empty
        /// gets the adress (zip + city + street)
        /// formats everything to string
        /// </summary>
        /// <returns></returns>
        public string GetCountry()
        {
            string countryString = country.ToString();
            countryString = countryString.Replace("_", " ");
            return countryString;
        }
        public bool Validation()
        {
            bool ok = !string.IsNullOrEmpty(city);
            return ok;
        }
        public string GetAddress()
        {
            string addressOut = street + Environment.NewLine;
            addressOut += zipCode + " " + city;
            return addressOut;
        }
        public override string ToString()
        {
            string addressFull = string.Format("{0, -25} {1, -8} {2, -10} {3}", street, zipCode, city, GetCountry());
            return addressFull;
        }
        #endregion
    }
}
