using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._02._23_HW
{
    public class Shop
    {
        private string name;
        private string street;
        private string description;
        private string number;
        private string email;
        public Shop() { }
        public Shop(string name, string street, string description, string number, string email)
        {
            this.name = name;
            this.street = street;
            this.description = description;
            this.number = number;
            this.email = email;
        }
        public string Name { get { return name; } set { name = value; } }
        public string Street { get { return street; } set { street = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string Number { get { return number; } set { number = value; } }
        public string Email { get { return email; } set { email = value; } }

        public void Print()
        {
            Console.WriteLine($"Name: {name}\n Street: {street}\nDescription: {description}\nNumber: {number}\nEmail: {email}");
        }

        public override string ToString()
        {
            return $"Name: {name}\n Street: {street}\nDescription: {description}\nNumber: {number}\nEmail: {email}";
        }

    }
}
