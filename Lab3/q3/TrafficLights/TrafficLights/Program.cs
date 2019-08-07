using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLights
{

    public delegate void TrafficDel();

    class TrafficSignal
    {
        public void Yellow()
        {
            Console.WriteLine("The Light is Yellow Now!");
        }

        public void Red()
        {
            Console.WriteLine("The Light is Red Now!");
        }

        public void Green()
        {
            Console.WriteLine("The Light is Green Now!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TrafficSignal ts = new TrafficSignal();
            TrafficDel mydel;
            mydel = ts.Yellow;
            mydel();
            mydel = ts.Red;
            mydel();
            mydel = ts.Green;
            mydel();
            Console.Read();
        }
    }
}
