using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._02._23_HW
{
    public class Magazine
    {
        private string name;
        private int year;
        private string description;
        private string number;
        private string email;
        public Magazine() { }
        public Magazine (string name, int year, string description, string number, string email)
        {
            this.name = name;
            this.year = year;
            this.description = description;
            this.number = number;
            this.email = email;
        }
        public string Name { get { return name; } set { name = value; } }
        public int Year { get { return year; } set { year = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string Number { get { return number; } set { number = value; } }
        public string Email { get { return email; } set { email = value; } }

        public void Print()
        {
            Console.WriteLine($"Name: {name}\n Year: {year}\nDescription: {description}\nNumber: {number}\nEmail: {email}");
        }

        public override string ToString()
        {
            return $"Name: {name}\n Year: {year}\nDescription: {description}\nNumber: {number}\nEmail: {email}";
        }
    }
}
