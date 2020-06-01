using System;

namespace practical5
{
    class Program
    {
        static void Main(string[] args)
        {
            Class5 myclass = new Class5();
            String infix, postfix;
            Console.WriteLine("enter infix like (x - y) * (w + z)");
            infix = Console.ReadLine();
         
            myclass.Infixtopostfix(ref infix, out postfix);
            Console.WriteLine("infix string : " + infix);
            Console.WriteLine("postfix string is : " + postfix);
            Console.Read();
        }
    }
}
