using System;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n-------- WELCOME TO THE ADDRESS BOOK SYSTEM PROGRAM ----------------");
            //Console.WriteLine("\n Enter The Contact Details :: ");

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

            Console.WriteLine("\n\nPlease Select Any One Number From Given List For Selecting Perticular Address Book ::");
            Console.WriteLine("1. Address Book A-");
            Console.WriteLine("2. Address Book B-");
            Console.WriteLine("3. Address Book C-");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    AddressBook add = new AddressBook();
                    Console.WriteLine("\n\nWELCOME TO THE ADDRESS BOOK - A");
                    while (true)
                    {
                        Console.WriteLine("\n\nSelect Any one Operation From Given List: ");
                        Console.WriteLine("1. To Add New Person: ");
                        Console.WriteLine("2. To Display Contacts: ");
                        Console.WriteLine("3. To Edit Any Contacts: ");
                        Console.WriteLine("4. To Remove Any Contacts: ");
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
                            case 3:
                                Console.WriteLine("Enter The Name For Edit Contact Details: ");
                                string eName = Console.ReadLine();
                                add.EditPersonDetails(eName);
                                add.Display();
                                break;
                            case 4:
                                Console.WriteLine("Enter The Name For Delete the Contact Details: ");
                                string rName = Console.ReadLine();
                                add.RemovePersonDetails(rName);
                                add.Display();
                                break;
                            default:
                                Console.WriteLine(" Please Select Correct Option ");
                                break;
                        }
                    }
                    break;

                case 2:
                    AddressBook add2 = new AddressBook();
                    Console.WriteLine("\n\nWELCOME TO THE ADDRESS BOOK - B");
                    while (true)
                    {
                        Console.WriteLine("\n\nSelect Any one Operation From Given List: ");
                        Console.WriteLine("1. To Add New Person: ");
                        Console.WriteLine("2. To Display Contacts: ");
                        Console.WriteLine("3. To Edit Any Contacts: ");
                        Console.WriteLine("4. To Remove Any Contacts: ");
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
                                add2.Display();
                                break;
                            case 3:
                                Console.WriteLine("Enter The Name For Edit Contact Details: ");
                                string eName2 = Console.ReadLine();
                                add2.EditPersonDetails(eName2);
                                add2.Display();
                                break;
                            case 4:
                                Console.WriteLine("Enter The Name For Delete the Contact Details: ");
                                string rName2 = Console.ReadLine();
                                add2.RemovePersonDetails(rName2);
                                add2.Display();
                                break;
                            default:
                                Console.WriteLine("Please Select Correct Option ");
                                break;
                        }
                    }
                    break;

                case 3:
                    AddressBook add3 = new AddressBook();
                    Console.WriteLine("\n\nWELCOME TO THE ADDRESS BOOK - C");
                    while (true)
                    {
                        Console.WriteLine("\n\nSelect Any one Operation From Given List: ");
                        Console.WriteLine("1. To Add New Person: ");
                        Console.WriteLine("2. To Display Contacts: ");
                        Console.WriteLine("3. To Edit Any Contacts: ");
                        Console.WriteLine("4. To Remove Any Contacts: ");
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
                                add3.Display();
                                break;
                            case 3:
                                Console.WriteLine("Enter The Name For Edit Contact Details: ");
                                string eName = Console.ReadLine();
                                add3.EditPersonDetails(eName);
                                add3.Display();
                                break;
                            case 4:
                                Console.WriteLine("Enter The Name For Delete the Contact Details: ");
                                string rName = Console.ReadLine();
                                add3.RemovePersonDetails(rName);
                                add3.Display();
                                break;
                            default:
                                Console.WriteLine(" Please Select Correct Option ");
                                break;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Please Select Correct Option ");
                    break;
            }
        }
    }
}
