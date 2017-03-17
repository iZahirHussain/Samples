#define DEBUG
using System;
using System.Diagnostics;
namespace CSharp.Attribute
{
    public class Myclass
    {
        [Conditional("DEBUG")]
        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    public class CondtionalAttributeClass 
    {
        static void function1()
        {
            Myclass.Message("In Function 1.");
            function2();
        }
        static void function2()
        {
            Myclass.Message("In Function 2.");
        }

        public static void ConditionalAttributeExample()
        {
            Myclass.Message("In Main function.");
            function1();
            Console.ReadKey();
        }
    }
}