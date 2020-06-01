using System;

namespace practical6
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            float f, c;
            Console.WriteLine("Enter your Choice from bellow:");
            Console.WriteLine("1. celcius to ferenhit");
            Console.WriteLine("2. ferenhit to celcius");
            ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1 :
                    Console.WriteLine("Enter input in celcius:");
                    c = float.Parse(Console.ReadLine());
                    f = c * (9 / 5) + 32;
                    Console.WriteLine("equivalant ferenheit:" + f);
                    break;

                case 2 :
                    Console.WriteLine("Enter input in ferenheit:");
                    f = float.Parse(Console.ReadLine());
                    c = (f - 32) * (5 / 9);
                    Console.WriteLine("equivalent celsuis:" + c);
                    break;

                default :
                    Console.WriteLine("Invalid Input");
                    break;

            }
            Console.Read();
        }
    }
}
