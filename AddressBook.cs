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
        public void Display()
        {
            foreach(Person pr in per)
            {
                Console.WriteLine(pr.Print());
            }
        }
        
    }
}
