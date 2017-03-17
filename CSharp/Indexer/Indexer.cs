using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.Indexer
{
    /*
     element-type this[int index]
     {
           // The get accessor.
           get
           {
              // return the value specified by index
           }
   
           // The set accessor.
           set
           {
              // set the value specified by index
           }
     } 
     */
    class Indexer
    {
        public const int MAXSIZE=5;
        private string[] studentList = new string[MAXSIZE];
        public Indexer()
        {
            for (int i = 0; i < MAXSIZE; i++)
            {
                studentList[i] = "N.A";
            }
        }

        public string this[int index]
        {
            get
            {
                return studentList[index];
            }
            set
            {
                studentList[index] = value;
            }
        }



        public int this[string value]
        {
            get
            {
                int index = 0;
                for (int i = 0; i < Indexer.MAXSIZE; i++)
                {
                    if (studentList[i] == value)
                    {
                        index = i;
                        break;
                    }
                }
                return index;
            }
        }
    }

    public class IndexerClass
    {
        public static void IndexerExample()
        {
            Indexer objStudents = new Indexer();
            objStudents[0] = "Zero";
            objStudents[1] = "One";
            objStudents[2] = "Two";

            Console.WriteLine("Indexer Example");


            for (int i = 0; i < Indexer.MAXSIZE; i++)
            {
                //Using Value;
                Console.Write("Value:" + objStudents[i]);

                //Using String Indexer; Get the Index;
                Console.WriteLine(", Index:" + objStudents[objStudents[i]]);
            }

            /*
             * //Output: 
             *  Indexer Example
                Value:Zero, Index:0
                Value:One, Index:1
                Value:Two, Index:2
                Value:N.A, Index:3
                Value:N.A, Index:3
            */

            Console.ReadKey();
        }
    }

}
