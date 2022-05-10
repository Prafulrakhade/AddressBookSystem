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
            string jsonData = JsonConvert.SerializeObject(per);
            File.WriteAllText(@"C:\Users\HP\Bridgelabz-145\Assignments_\Day 9\AddressBookSystem\AddressBookSystem\AddressBokkResult.json", jsonData);
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
