// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
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
    /// New object of AddressBook is instantiated to create new class
    /// </summary>
    public class AddressBook
    {
        /// <summary>
        /// contactList stores all contacts of one AddressBook
        /// </summary>
        private readonly List<Contact> contactList = new List<Contact>();

        /// <summary>
        /// nameToContactMapper is used to access contact details using name of person
        /// </summary>
        private readonly Dictionary<string, Contact> nameToContactMapper = new Dictionary<string, Contact>();

        /// <summary>
        /// This function is used to add new Contact in AddressBook
        /// </summary>
        public void AddContacts()
        {
            bool flag = true;
            while (flag)
            {
                Contact contact = new Contact();
                this.contactList.Add(contact);
                this.nameToContactMapper.Add(contact.firstName + " " + contact.lastName, contact);
                Console.WriteLine("\nContact created successfully with following details: ");
                Console.WriteLine("FirstName: " + contact.firstName + "\nLast Name :" + contact.lastName);
                Console.WriteLine("Address: " + contact.address + "\nCity: " + contact.city);
                Console.WriteLine("State: " + contact.state + "\nZip: " + contact.zip);
                Console.WriteLine("Phone Number: " + contact.phoneNumber + "\nEmail: " + contact.email);
                Console.WriteLine("\nTo Add a New Contact Enter YES");
                string option = Console.ReadLine();
                if (option != "YES")
                {
                    flag = false;
                }
            }
        }

        /// <summary>
        /// EditDetails is used to modify contact details of a person using complete name
        /// </summary>
        public void EditDetails()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nTo modify details, enter firstname followed by a space, followed by lastname of the contact");
                string name = Console.ReadLine();
                if (this.nameToContactMapper.ContainsKey(name))
                {
                    Contact contact = this.nameToContactMapper[name];
                    Console.WriteLine("Enter Latest Details of Contact!");

                    Console.WriteLine("Enter First Name of Contact");
                    string firstName = Console.ReadLine();
                    contact.firstName = firstName;

                    Console.WriteLine("Enter Last Name of Contact");
                    string lastName = Console.ReadLine();
                    contact.lastName = lastName;

                    Console.WriteLine("Enter Address");
                    string address = Console.ReadLine();
                    contact.address = address;

                    Console.WriteLine("Enter City");
                    string city = Console.ReadLine();
                    contact.city = city;

                    Console.WriteLine("Enter state");
                    string state = Console.ReadLine();
                    contact.state = state;

                    Console.WriteLine("Enter zip");
                    string zip = Console.ReadLine();
                    contact.zip = zip;

                    Console.WriteLine("Enter Phone Number");
                    string phoneNumber = Console.ReadLine();
                    contact.phoneNumber = phoneNumber;

                    Console.WriteLine("Enter Email");
                    string email = Console.ReadLine();
                    contact.email = email;

                    Console.WriteLine("\nDetails modified successfully with following entries: ");
                    Console.WriteLine("FirstName: " + contact.firstName + "\nLast Name :" + contact.lastName);
                    Console.WriteLine("Address: " + contact.address + "\nCity: " + contact.city);
                    Console.WriteLine("State: " + contact.state + "\nZip: " + contact.zip);
                    Console.WriteLine("Phone Number: " + contact.phoneNumber + "\nEmail: " + contact.email);
                }
                else
                {
                    Console.WriteLine("Entered name did't match with any record!");
                    Console.WriteLine("Valid names: ");
                    foreach (Contact contact in this.contactList)
                    {
                        Console.WriteLine(contact.firstName + " " + contact.lastName);
                    }
                }

                Console.WriteLine("\nTo update more contact details enter YES");
                string option = Console.ReadLine();
                if (option != "YES")
                {
                    flag = false;
                }
            }
        }

        /// <summary>
        /// DeleteContact function is used to delete Contact from AddressBook using full name of the person
        /// </summary>
        public void DeleteContact()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nTo Delete Contact, enter firstname followed by a space, followed by lastname of the contact");
                string name = Console.ReadLine();
                if (this.nameToContactMapper.ContainsKey(name))
                {
                    Contact contact = this.nameToContactMapper[name];
                    var index = this.contactList.FindIndex(i => i == contact); // like Where/Single
                    if (index >= 0)
                    {   // ensure item found
                        this.contactList.RemoveAt(index);
                    }

                    this.nameToContactMapper.Remove(name);
                    Console.WriteLine("Contact deleted successfully");
                }
                else
                {
                    Console.WriteLine("Entered name did't match with any record!");
                    Console.WriteLine("Valid names: ");
                    foreach (Contact contact in this.contactList)
                    {
                        Console.WriteLine(contact.firstName + " " + contact.lastName);
                    }
                }

                Console.WriteLine("\nTo Delete more contact details enter YES");
                string option = Console.ReadLine();
                if (option != "YES")
                {
                    flag = false;
                }
            }
        }
    }
}
