// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Contact.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akshay"/>
// --------------------------------------------------------------------------------------------------------------------
namespace AddressBookSystem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Object of contact class stores all information of a contact
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Variables to store first name, last name, address, city, state, zip, phone number and email 
        /// Easy to understand with given names
        /// </summary>
        public string firstName, lastName, address, city, state, zip, phoneNumber, email;

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        public Contact()
        {
            Console.WriteLine("Enter First Name of Contact");
            string firstName = Console.ReadLine();
            this.firstName = firstName;

            Console.WriteLine("Enter Last Name of Contact");
            string lastName = Console.ReadLine();
            this.lastName = lastName;

            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            this.address = address;

            Console.WriteLine("Enter City");
            string city = Console.ReadLine();
            this.city = city;

            Console.WriteLine("Enter state");
            string state = Console.ReadLine();
            this.state = state;

            Console.WriteLine("Enter zip");
            string zip = Console.ReadLine();
            this.zip = zip;

            Console.WriteLine("Enter Phone Number");
            string phoneNumber = Console.ReadLine();
            this.phoneNumber = phoneNumber;

            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            this.email = email;
        }
    }
}
