using System;

namespace _12_Task
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Antonina";
            string surname = "Grigorova";
            byte age = 21;
            char gender = 'F';
            ulong id = 27569999;
            Console.WriteLine("Name:{0} {1}"
                            , name, surname );
            Console.WriteLine("{0}, {1} years old"
                                , gender, age);
            Console.WriteLine("ID Number: {0}"
                                , id);

        }
    }
}