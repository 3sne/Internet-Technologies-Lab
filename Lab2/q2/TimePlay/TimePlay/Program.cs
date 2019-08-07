using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    class Program
    {
        static void Main(string[] args)
        {
            string dt;
            string time;
            string n;
            long ticks;
            Console.WriteLine("Enter DD:MM:YY-");
            dt = Console.ReadLine();
            Console.WriteLine("Enter hh:mm:ss-");
            time = Console.ReadLine();
            Console.WriteLine("Enter ticks-");
            n = Console.ReadLine();
            long.TryParse(n, out ticks);
            DateTimeAdd(dt, time, ticks);

        }
        static void DateTimeAdd(string dt, string time, long ticks)
        {
            int dd, mm, yy, h, m, s, temp;
            int.TryParse(dt.Substring(0, 2), out dd);
            int.TryParse(dt.Substring(3, 2), out mm);
            int.TryParse(dt.Substring(6, 2), out yy);
            int.TryParse(time.Substring(0, 2), out h);
            int.TryParse(time.Substring(3, 2), out m);
            int.TryParse(time.Substring(6, 2), out s);
            int k = (int)(ticks / 10000000);

            temp = (s + k) % 60;
            k = (s + k) / 60;
            s = temp;

            temp = (m + k) % 60;
            k = (m + k) / 60;
            m = temp;

            temp = (h + k) % 24;
            k = (h + k) / 24;
            h = temp;

            temp = (dd + k) % 30;
            k = (dd + k) / 31;
            dd = temp;

            temp = (mm + k) % 12;
            k = (mm + k) / 12;
            mm = temp;

            yy = yy + k;
            Console.WriteLine("Date- {0}:{1}:{2}\t Time- {3}:{4}:{5}", dd.ToString(), mm.ToString(), yy.ToString(), h.ToString(), m.ToString(), s.ToString());
            Console.Read();


        }
    }
}