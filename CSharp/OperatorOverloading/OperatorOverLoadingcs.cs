using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp
{
    class PersonSalary
    {
        public int Basic { get; set; }

        public int CTC { get; set; }

        //+ Operator OverLoading:
        public static PersonSalary operator +(PersonSalary p1, PersonSalary p2)
        {
            PersonSalary result = new PersonSalary();
            result.Basic = p1.Basic + p2.Basic;
            result.CTC = p1.CTC + p2.CTC;

            return result;
        }

        public static bool operator &(PersonSalary p1, PersonSalary p2)
        {
            return (p1.Basic == p2.Basic && p1.CTC == p2.CTC);
        }

        //Not Possible: One of the Parameter of a Binary Operator must be a containing Type.
        //The parameter must have a Class Type. eg. PersonSalary Class.
        /*
        public static int operator +(int p1, int p2)
        {
            return p1 - p2;
        }
        */ 
    }

    

    public class OperatorOverLoading
    {
        //http://www.tutorialspoint.com/csharp/csharp_operator_overloading.htm

        //public PersonSalary GetPerson(int _basic, int _ctc)
        //{
        //    return new PersonSalary { Basic = _basic, CTC = _ctc };
        //}

        public void OperatorOverLoadExample()
        {
            PersonSalary p1 = new PersonSalary { Basic = 15000, CTC = 25000 };
            PersonSalary p2 = new PersonSalary { Basic = 25000, CTC = 30000 };
            
            PersonSalary Total = p1 + p2;
            Console.WriteLine("Operator OverLoading Example:");
            Console.WriteLine("+ Operator: Total \nBasic: {0}, CTC: {1}\n", Total.Basic,Total.CTC);

            PersonSalary p1Copy = new PersonSalary { Basic = 15000, CTC = 25000 };

            Console.WriteLine("P1 & P1Copy Result:{0}", (p1 & p1Copy) & (p1 & p2));
            Console.WriteLine("P1 & P2 Result:{0}", p1 & p2);

            Console.WriteLine("P1 + P2 Result:{0}", 1 + 1);

            Console.ReadKey();
        }

        
    }


}
