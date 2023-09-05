using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4.Create a base class with protected members and derive a class to access those members.
namespace LAB_ASSIGNMENT_3
{
    
    // Base class with protected members
    public class MyBaseClass
    {
        protected int protectedField = 42;

        protected void ProtectedMethod()
        {
            Console.WriteLine("ProtectedMethod called from MyBaseClass");
        }
    }

    // Derived class accessing protected members
    public class MyDerivedClass : MyBaseClass
    {
        public void AccessProtectedMembers()
        {
            Console.WriteLine($"Accessing protectedField from MyDerivedClass: {protectedField}");
            ProtectedMethod();
        }
    }

    class Program4
    {
        static void Main4(string[] args)
        {
            MyDerivedClass derivedInstance = new MyDerivedClass();

            // Access protected members from the derived class
            derivedInstance.AccessProtectedMembers();
            Console.ReadKey();
        }
    }

}
