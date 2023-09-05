using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6.Create a class with a public property. Derive another class and try to access the property.
namespace LAB_ASSIGNMENT_3
{
    

    // Base class with a public property
    public class MyBaseClass1
    {
        public int MyProperty { get; set; }
    }

    // Derived class that accesses the property
    public class MyDerivedClass1 : MyBaseClass1
    {
        public void AccessProperty()
        {
            // Access the property from the derived class
            MyProperty = 42;
            Console.WriteLine($"Value of MyProperty in MyDerivedClass: {MyProperty}");
        }
    }

    class Program6
    {
        static void Main6(string[] args)
        {
            MyDerivedClass1 derivedInstance = new MyDerivedClass1();

            // Access the property from the derived class
            derivedInstance.AccessProperty();
            Console.ReadKey();
        }
    }

}
