using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _06._02._23_HW;

namespace HW_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebSite site = new WebSite();
            site.Name = "GitHub";
            site.Url = "https://github.com";
            site.Description = "Repositories/Hosting";
            site.Ip = "192.30.252.154";
            Console.WriteLine(site);

            Magazine magazine = new Magazine();
            magazine.Name = "Train";
            magazine.Description = "Sport";
            magazine.Year = 2010;
            magazine.Number = "+XX-XXX-XXX-XXXX";
            magazine.Email = "xxxxxxxxxxx@mail.com";
            Console.WriteLine(magazine);

            Shop shop = new Shop();
            shop.Name = "Kopeyka";
            shop.Description = "Product shop";
            shop.Street = "Govorova 7";
            shop.Number = "+XX-XXX-XXX-XXXX";
            shop.Email = "xxxxxxxxxxx@mail.com";
            Console.WriteLine(shop);
        }
    }
}
