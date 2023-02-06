using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._02._23_HW
{
    public class WebSite
    {
        private string name;
        private string url;
        private string description;
        private string ip;

        public WebSite() { }
        public WebSite(string name, string url, string description, string ip)
        {
            this.name = name;
            this.url = url;
            this.description = description;
            this.ip = ip;
        }

        public string Name { get { return name; } set { name = value; } }
        public string Url { get { return url; } set { url = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string Ip { get { return ip; } set { ip = value; } }

        public void Print()
        {
            Console.WriteLine($"Name: {name}\nURL: {url}\nDescription {description}\nIP: {ip}");
        }
        public override string ToString()
        {
            return $"Name: {name}\nURL: {url}\nDescription {description}\nIP: {ip}";
        }

    }
}
