using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AddressBookSystem
{
    internal class Person
    {
        public string First_Name;
        public string Last_Name;
        public string Address;
        public string City;
        public string State;
        public long Zip_Code;
        public long Phone_Number;
        public string Email_ID;

        public string Print()
        {
            return "First Name: " + First_Name + "\n Last name: " + Last_Name + "\n Address: " + Address + "\n City: " + City +
            "\n State:" + State + "\n Zip Code: " + Zip_Code + "\n Phone Number: " + Phone_Number + "\n Email ID: " + Email_ID;
        }
    }
}
