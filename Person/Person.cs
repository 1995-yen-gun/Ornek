using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Person
    {
        public string  Name { get; set; } 
        public int Age { get; set; }

        public string Address { get; set; } 
        public string City { get; set; }    
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public int Tc { get; set; }     

        public Person(string name, int age, string address, string city, string region
            , string postalCode, int tc)
        {
            Name = name;
            Age = age;
            Address = address;
            City = city;
            Region = region;
            PostalCode = postalCode;
            Tc = tc;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Name: "+ Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Address:"+Address);
            Console.WriteLine("City:" + City);
            Console.WriteLine("Region:" + Region);
            Console.WriteLine("PostalCode:"+ PostalCode);
            Console.WriteLine("Tc:"+ Tc);

        }
    }
}
