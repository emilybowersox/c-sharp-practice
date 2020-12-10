using System;

namespace Hello_World
{
    class MainClass
    {
        static int age = 28;
        //whole numbers -128 - 127)
        sbyte x = 300;

        //variable exaple with no value: default value assigned = 0
        static int myAge;

        public static void Main(string[] args)
        {
            age = 20;

            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Emily!");
            Console.WriteLine("Can I push from the terminal now?");
            Console.WriteLine("I want to commit");
            Console.WriteLine(age);
            Console.WriteLine(myAge);

        }
    }
}
