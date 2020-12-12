using System;

namespace Hello_World
{
    class MainClass
    {
        //visual code for mac notes: i'm not sure yet if logging in with my github email or pushing
        //through just the version control tab fixed it- still need to figure our pushing
        //through th

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

        //primitive data types

        static bool falseBoolean = false;
        static bool trueBoolean = true;

        static char myLetter = 'A';
        // char uses 'single quotes'

        static string myName = "Emily";
        // string uses "double quotes"



        public static void Main(string[] args)
        {
            age = 20;
            int myNumber = 13;

            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Emily!");
            Console.WriteLine("Can I push from the terminal now?");
            Console.WriteLine("I want to commit");
            Console.WriteLine(age);
            Console.WriteLine(myAge);
            Console.WriteLine(myNumber);
            Console.WriteLine(myName);

        }
    }
}
