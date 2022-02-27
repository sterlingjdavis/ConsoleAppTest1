using System;

namespace ConsoleAppTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            string function = "";
            while (function != "exit")
            {
                Console.Write("Press operator [+, -, *, /] or type 'exit' to terminate program: ");
                function = Console.ReadLine();

                if (function != "exit")
                {
                    Console.Write("First number: ");
                    double valueOne = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Second Number: ");
                    double valueTwo = Convert.ToDouble(Console.ReadLine());

                    if (function == "+")
                    {
                        Console.WriteLine(valueOne + valueTwo);
                    }
                    else if (function == "-")
                    {
                        Console.WriteLine(valueOne - valueTwo);
                    }
                    else if (function == "*")
                    {
                        Console.WriteLine(valueOne * valueTwo);
                    }
                    else if (function == "/")
                    {
                        Console.WriteLine(valueOne / valueTwo);
                    }
                }

            }

            Console.Write("Press the 'enter' key to exit... ");
            Console.ReadLine();
        }
    }
}