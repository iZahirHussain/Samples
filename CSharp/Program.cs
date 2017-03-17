using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharp.Delegate;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Generic

            /*
            Generic gen = new Generic();
            gen.GenericClassExample();
            gen.GenericMethodExample();
            gen.GenericInterfaceExample();
            */
            #endregion

            #region Operator OverLoading
            /*
            //Operator OverLoading
            OperatorOverLoading overLoad = new OperatorOverLoading();
            overLoad.OperatorOverLoadExample();
            */
            #endregion

            #region Delegate
            //MSDN
            //CSharp.Delegate.BookStoreClient.BookStoreExample();

            /*
            //My Sample
            DelegateTest delExample = new DelegateTest();
            delExample.DelegateExample();
            */

            #endregion

            #region AbstractClass
            /*
            Abstract.AbstractTest abs = new Abstract.AbstractTest();
            abs.AbstractExample();
            */
            #endregion

            #region Attribute

            //CSharp.Attribute.AttributeMainClass.AttributeExample();
            
            //CSharp.Attribute.CondtionalAttributeClass.ConditionalAttributeExample();

            //CSharp.Attribute.ReflectionExampleClass.ReflectionExample(); 
            #endregion

            #region Indexer

            //CSharp.Indexer.IndexerClass.IndexerExample();
            
            #endregion
        }

    }

}
