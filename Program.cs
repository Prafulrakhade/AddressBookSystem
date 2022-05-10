using System;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n-------- WELCOME TO THE ADDRESS BOOK SYSTEM PROGRAM ----------------");
            Console.WriteLine("\n Enter The Contact Details :: ");

            //Person person = new Person();
            //Console.Write("Enter the First Name : ");
            //string name = Console.ReadLine();
            //person.First_Name = name;
            //Console.Write("Enter the Last Name : ");
            //string lastName = Console.ReadLine();
            //person.Last_Name = lastName;
            //Console.Write("Enter the Address : ");
            //string address = Console.ReadLine();
            //person.Address = address;
            //Console.Write("Enter the City Name : ");
            //string city = Console.ReadLine();
            //person.City = city;
            //Console.Write("Enter the  State Name : ");
            //string state = Console.ReadLine();
            //person.State = state;
            //Console.Write("Enter the  Zip Code : ");
            //long zip = long.Parse(Console.ReadLine());
            //person.Zip_Code = zip;
            //Console.Write("Enter the Phone Number : ");
            //long phone = long.Parse(Console.ReadLine());
            //person.Phone_Number = phone;
            //Console.Write("Enter the  Email ID : ");
            //string email = Console.ReadLine();
            //person.Email_ID = email;
            //Console.WriteLine();
            //add.AddPerson(person);
            //add.Display();
            //Console.WriteLine("---------------------------------------------------------------------------------------------");

            //AddressBook edit = new();
            //edit.Display();
            //Console.WriteLine("Enter The Name For Edit Contact Details: ");
            //Console.WriteLine();
            //string Name = Console.ReadLine();
            //edit.EditPersonDetails(Name);
            //edit.Display();
            //Console.WriteLine("---------------------------------------------------------------------------------------------");


            //AddressBook delete = new AddressBook();
            //delete.Display();
            //Console.WriteLine("Enter The Name For Delete the Contact Details: ");
            //string Name2 = Console.ReadLine();
            //delete.RemovePersonDetails(Name2);
            //delete.Display();
            //Console.WriteLine("---------------------------------------------------------------------------------------------");

            AddressBook add = new AddressBook();
            while (true)
            {
                Console.WriteLine("\nSelect Any one Operation: ");
                Console.WriteLine("1. To Add New Person: ");
                Console.WriteLine("2. To Display Contacts: ");
                int read = int.Parse(Console.ReadLine());
                switch (read)
                {
                    case 1:
                        Person person = new Person();
                        Console.Write("Enter the First Name : ");
                        string name = Console.ReadLine();
                        person.First_Name = name;
                        Console.Write("Enter the Last Name : ");
                        string lastName = Console.ReadLine();
                        person.Last_Name = lastName;
                        Console.Write("Enter the Address : ");
                        string address = Console.ReadLine();
                        person.Address = address;
                        Console.Write("Enter the City Name : ");
                        string city = Console.ReadLine();
                        person.City = city;
                        Console.Write("Enter the  State Name : ");
                        string state = Console.ReadLine();
                        person.State = state;
                        Console.Write("Enter the  Zip Code : ");
                        long zip = long.Parse(Console.ReadLine());
                        person.Zip_Code = zip;
                        Console.Write("Enter the Phone Number : ");
                        long phone = long.Parse(Console.ReadLine());
                        person.Phone_Number = phone;
                        Console.Write("Enter the  Email ID : ");
                        string email = Console.ReadLine();
                        person.Email_ID = email;
                        break;

                    case 2:
                        add.Display();
                        break;
                }
            }
        }
    }
}
