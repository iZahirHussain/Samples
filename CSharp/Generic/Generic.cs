using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp
{
    public class Generic
    {
        //http://www.c-sharpcorner.com/article/understanding-t-in-C-Sharp/

        #region Generic
        //Generic Class 
        public void GenericClassExample()
        {
            GenericClass<Products> generic = new GenericClass<Products>();
            generic.SetData(new Products { ID = 1, Name = "One" });
            generic.GetData();

            GenericClass<int> generic1 = new GenericClass<int>();
            generic1.SetData(1);
            generic1.GetData();
            Console.ReadKey();
        }

        //Generic Method
        public void GenericMethodExample()
        {
            GenericMethodExample ex = new GenericMethodExample();
            ex.GenericMethod<int>(1, 2);
            ex.GenericMethod<string>("C#", "Generic Method");
        }

        public void GenericInterfaceExample()
        {
            GenericInterfaceExample<string> genInt = new GenericInterfaceExample<string>();
            genInt.ShowData("Generic Interface");
        }

        #endregion
    }

    #region Generic Interface

    //Generic Interface
    interface IGenericInterface<T>
    {
        void ShowData(T t);
    }

    class GenericInterfaceExample<T> : IGenericInterface<T>
    {
        public void ShowData(T t)
        {
            Console.WriteLine("Generic Interface Example:");
            Console.WriteLine(t);
            Console.ReadKey();
        }
    }

    #endregion

    public class GenericClass<T>
    {
        T data;
        public void SetData(T t)
        {
            data = t;
        }

        public void GetData()
        {
            Products prod = data as Products;

            if (prod != null)
            {
                Console.WriteLine("Generic Class Example");
                Console.WriteLine(prod.ID);
                Console.WriteLine(prod.Name);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(data);
            }
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose");
        }
    }

    public class GenericMethodExample
    {
        public void GenericMethod<T>(T a, T b)
        {
            Console.WriteLine("Generic Method Example");
            Console.WriteLine("Result:" + " " + a + b);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
