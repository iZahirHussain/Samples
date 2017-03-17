using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.Delegate
{
    public class DelegateClass
    {
        protected delegate void MyDelegate(int number);
        protected void DelegateMethod(int i)
        {
            Console.WriteLine("You Entered: {0}", i);
        }

        protected void DelegateMethod2(int i)
        {
            Console.WriteLine("Then You Entered: {0}", i);
        }
    }

    public class DelegateTest:DelegateClass
    {
        public void DelegateExample()
        {
            MyDelegate delObj1 = new MyDelegate(DelegateMethod);
            MyDelegate delObj2=new MyDelegate(DelegateMethod2);
            
            delObj1(1);

            delObj2(2);
            Console.ReadKey();
            
        }
    }
}
