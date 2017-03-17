using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
namespace CSharp.Attribute
{
    public class MyAttrAttribute : System.Attribute
    {
        public readonly string Message;
        public readonly int Number;
        public MyAttrAttribute(string myAttributeMsg, int number)
        {
            this.Message = myAttributeMsg;
            this.Number = number;
        }

        public string MyMessage
        {
            get
            {
                return myMessage;
            }
            set
            {
                myMessage = value;
            }
        }

        private string myMessage;
    }

    [MyAttr("Test Message", 1)]
    public class AttributeClass
    {
        public void TestMethod()
        {
            Console.WriteLine("Test Method.");
        }
    }

    public class ReflectionExampleClass
    {
        public static void ReflectionExample()
        {
            AttributeClass att = new AttributeClass();
            att.TestMethod();
            Type type = typeof(AttributeClass);
            System.Reflection.MethodInfo[] methodInfo = type.GetMethods();

            foreach (object obj in type.GetCustomAttributes(true))
            {
                if (obj != null)
                {
                    MyAttrAttribute myAttr = (MyAttrAttribute)obj;
                    myAttr.MyMessage = "Message Added at run time.";
                    Console.WriteLine("Message: {0}. Number {1}", myAttr.Message +";"+myAttr.MyMessage, myAttr.Number);
                    Console.ReadKey();
                }
            }
        }

    }
}
