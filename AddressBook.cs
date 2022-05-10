using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace AddressBookSystem
{
    internal class AddressBook
    {
        public List<Person> per = new List<Person>();
        public void Display()
        {
            foreach (Person pr in per)
            {
                Console.WriteLine(pr.Print());
            }
        }
        public void AddPerson(Person p)
        {
            per.Add(p);
            string jsonData = JsonConvert.SerializeObject(per);  // it convert custom to Json.... Json Convert the Serialize Object data into the string data (i.e. covert from list to string ) 
            File.WriteAllText(@"C:\Users\HP\Bridgelabz-145\Assignments_\Day 9\AddressBookSystem\AddressBookSystem\AddressBokkResult.json", jsonData);
            //File.WriteAllText string data stored in Json File.  
        }

        public AddressBook()
        {
            string json = File.ReadAllText(@"C:\Users\HP\Bridgelabz-145\Assignments_\Day 9\AddressBookSystem\AddressBookSystem\AddressBokkResult.json");
            if (json.Length > 0)
            {
                per = JsonConvert.DeserializeObject<List<Person>>(json); //it convert Json to the custom (i.e. string to list)
            }
            else
            {
                per = new List<Person>();
            }
        }
        public void EditPersonDetails(string First_Name)
        {
            for (int i = 0; i < per.Count; i++)
            {
                if (per[i].First_Name == First_Name)
                {
                    Console.Write("Enter The First Name: ");
                    per[i].First_Name = Console.ReadLine();
                    Console.Write("Enter The Last Name: ");
                    per[i].Last_Name = Console.ReadLine();
                    Console.Write("Enter The Address: ");
                    per[i].Address = Console.ReadLine();
                    Console.Write("Enter The City: ");
                    per[i].City = Console.ReadLine();
                    Console.Write("Enter The State: ");
                    per[i].State = Console.ReadLine();
                    Console.Write("Enter The Zip Code: ");
                    per[i].Zip_Code = long.Parse(Console.ReadLine());
                    Console.Write("Enter The Phone Number: ");
                    per[i].Phone_Number = long.Parse(Console.ReadLine());
                    Console.Write("Enter The Email ID: ");
                    per[i].Email_ID = Console.ReadLine();
                }
            }
            string jsonData = JsonConvert.SerializeObject(per);  // it convert custom to Json.... Json Convert the Serialize Object data into the string data (i.e. covert from list to string ) 
            File.WriteAllText(@"C:\Users\HP\Bridgelabz-145\Assignments_\Day 9\AddressBookSystem\AddressBookSystem\AddressBokkResult.json", jsonData);
        }
        public void RemovePersonDetails(string First_Name)
        {
            Person persn = null;
            foreach (Person del in per)
            {
                if (del.First_Name == First_Name)
                {
                    persn = del;
                }
            }
            per.Remove(persn);
            string jsonData = JsonConvert.SerializeObject(per);
            File.WriteAllText(@"C:\Users\HP\Bridgelabz-145\Assignments_\Day 9\AddressBookSystem\AddressBookSystem\AddressBokkResult.json", jsonData);
        }
    }
}
