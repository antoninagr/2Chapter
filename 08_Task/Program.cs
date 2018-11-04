using System;

namespace _08_Task
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string hello = "Hello";
            string world = "World";

            object obj = hello + " " + world;
            Console.WriteLine("The object variable is: {0}", obj);

            string str = (string)(obj);
            Console.WriteLine("The string variable is: {0}", str);
                               
        }
    }
}
