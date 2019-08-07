using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemPricePlay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Item\n=====\nName >> ");
            string tname = Console.ReadLine();
            Console.Write("Price >> ");
            float tprice;
            if (float.TryParse(Console.ReadLine(), out tprice) == false)
            {
                Console.WriteLine("INPUT ERROR, BYE");
                return;
            }
            Item i = new Item();
            i.itemName = tname;
            i.ItemPrice = tprice;
           // i.event1 += i.priceChange;
            //  Console.Write(i.ToString());
            Console.Write("Enter new item price >> ");
            float.TryParse(Console.ReadLine(), out tprice);
            i.ItemPrice = tprice;
            Console.Read();
        }
    }
}
