using System;

namespace Hello_World
{
    class MainClass
    {
        // sbyte = whole numbers -128 - 127)
        // short =  whole numbers -32767 - 32767
        // int = whole numbers ~ -2 to 2 billion
        // long = whole numbers that are the biggest

        static float x = 99.99f;
        //must use "f" or it will consider it a double (7 digit precision) (used in video games- processing power > accuracy) 
        static double y = 100.994829;
        // double = decimals up to 15 digit precision (used for real world vales except money calculations) 
        // decimal = decialms up to 28 digit precision (used in financial applications for high level of accuracy)


        static int age = 28;
        static int myAge;
            //variable example with no value: default value assigned = 0

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
