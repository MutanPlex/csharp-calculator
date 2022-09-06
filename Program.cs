using System;

namespace calculator
{
    class Program
    {
        static int operation,r,c,d,e;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("╔╦╗┬ ┬┌┬┐┌─┐┌┐┌╔═╗┬  ┌─┐─┐ ┬\n║║║│ │ │ ├─┤│││╠═╝│  ├┤ ┌┴┬┘\n╩ ╩└─┘ ┴ ┴ ┴┘└┘╩  ┴─┘└─┘┴ └─");
            Console.WriteLine("         Calculator \n\n");

            start();
            go();

            
            Console.ForegroundColor = ConsoleColor.White;

        }
        static void sum(int a, int b)
        {
            r = a + b;
            Console.WriteLine("\nAnswer " + r);
        }
        static void substraction(int a,int b)
        {
            r = a - b;
            Console.WriteLine("\nAnswer " + r);
        }
        static void multiply(int a, int b)
        {
            r = a * b;
            Console.WriteLine("\nAnswer " + r);
        }
        static void divide(int a, int b)
        {
            r = a / b;
            Console.WriteLine("\nAnswer " + r);
        }
        static void start()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("What action will you take?");
            Console.WriteLine("1) Addition       2) Substraction");
            Console.WriteLine("3) Multiply       4) Division\n");

            operation = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
        }
        static void go()
        {
            if (operation == 1)
            {
                Console.WriteLine("Enter the number you want to sum");
                c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter other number");
                d = Convert.ToInt32(Console.ReadLine());
                sum(c, d);
                resume();
            }
            if (operation == 2)
            {
                Console.WriteLine("Enter the number you want to subtract");
                c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter other number");
                d = Convert.ToInt32(Console.ReadLine());
                substraction(c, d);
                resume();
            }
            if (operation == 3)
            {
                Console.WriteLine("Enter the number you want to multiply");
                c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter other number");
                d = Convert.ToInt32(Console.ReadLine());
                multiply(c, d);
                resume();
            }
            if (operation == 4)
            {
                Console.WriteLine("Enter the number you want to divide");
                c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter other number");
                d = Convert.ToInt32(Console.ReadLine());
                divide(c, d);
                resume();
            }
        }
        static void resume()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nDo you want to continue?");
            Console.WriteLine("1) Yes        2) No\n");
            int g = Convert.ToInt32(Console.ReadLine());
            if(g == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                resumex();
            }
        }
        static void resumex()
        {
            if (operation == 1)
            {
                Console.WriteLine("Enter other number");
                e = Convert.ToInt32(Console.ReadLine());
                sum(r, e);
                resume();
            }
            if (operation == 2)
            {
                Console.WriteLine("Enter other number");
                e = Convert.ToInt32(Console.ReadLine());
                substraction(r, e);
                resume();
            }
            if (operation == 3)
            {
                Console.WriteLine("Enter other number");
                e = Convert.ToInt32(Console.ReadLine());
                multiply(r, d);
                resume();
            }
            if (operation == 4)
            {
                Console.WriteLine("Enter other number");
                e = Convert.ToInt32(Console.ReadLine());
                divide(r, e);
                resume();
            }
        }
    }
}
