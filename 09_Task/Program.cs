using System;

namespace _09_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "The \"use\" of quotations causes difficulties.";
            string strr = "The " + "\u0022" + "use" + "\u0022" + " of quotations causes difficulties.";
            Console.WriteLine(str);
            Console.WriteLine(strr);
        }
    }
}