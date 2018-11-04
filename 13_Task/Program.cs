using System;

namespace _13_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Initial values a={0} b={1}"
                                , a, b);

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Values after swap a={0} b={1}"
                                , a, b);



        }
    }
}
