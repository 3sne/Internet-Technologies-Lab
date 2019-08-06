using System;
namespace ArithOps
{
    class Program
    {

        static int a;
        static int b;

        static int showMenu()
        {
            Console.WriteLine();
            Console.WriteLine("======MENU======");
            Console.WriteLine("Which arithmetic operation parfom do?");
            Console.Write("1. a + b\n2. a - b\n3. a * b\n4. a / b\n5. a % b\n0.Exit\n[In] ");
            int msel;
            if (Int32.TryParse(Console.ReadLine(), out msel) == false)
            {
                Console.Write("Invalid Input!");
                return -3;
            }
            if (msel > 5 || msel < 0)
            {
                return -1;
            }
            if (msel == 0) {
                return 0;
            }
            Console.Write("[In] a >> ");
            if(Int32.TryParse(Console.ReadLine(), out a) == false)
            {
                Console.Write("Invalid Input!");
                return -2;
            }
            Console.Write("[In] b >> ");
            if (Int32.TryParse(Console.ReadLine(), out b) == false)
            {
                Console.Write("Invalid Input!");
                return -2;
            }
            /* [0-5] => valid | [-1] => bad menu entry | [-2] => bad number entry*/
            return msel;
        }

        static void Main(string[] args)
        {
            int ans = 0;
            while (true)
            {
                int sel = showMenu();
                if (sel == 0)
                {
                    break;
                }
                if (sel == -1 || sel == -2 || sel == -3)
                {
                    continue;
                }
                switch (sel)
                {
                    default: Console.WriteLine("This shouldn't be printed!"); break;
                    case 1: ans = a + b; break;
                    case 2: ans = a - b; break;
                    case 3: ans = a * b; break;
                    case 4: ans = a / b; break;
                    case 5: ans = a % b; break;
                    case 0: break;
                }
                Console.WriteLine("[Out] " + ans);
            }
            Console.WriteLine("BYE");
            Console.Read();
        }
    }
}
