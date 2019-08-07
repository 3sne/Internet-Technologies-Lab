using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGster
{
    class Program
    {
        static void Main(string[] args)
        {
            Item i = new Item();
            Console.Write("[In] Enter Item Name >> ");
            string tname = Console.ReadLine();
            float tcost;
            Console.Write("[In] Enter Item Cost >> ");
            float.TryParse(Console.ReadLine(), out tcost);
            i.name = tname;
            i.Cost = tcost;
            Console.WriteLine("[Out] The GST is " + i.Gst);
            Console.Read();
        }
    }
}
