using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.Abstract
{
    abstract public class AbstractClass
    {
        abstract public void AbstractExample();
    }

    public class AbstractTest:AbstractClass
    {
        //The Method AbstractExample Must have the Implementation in the derived class of ''AbstractClass''
        public override void AbstractExample()
        {
            Console.WriteLine("Abstract Method Implemented.");
            Console.ReadKey();
        }
    }
}
