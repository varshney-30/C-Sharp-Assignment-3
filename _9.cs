using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//9.Implement a class with a protected method. Derive a class and access the protected method.
namespace LAB_ASSIGNMENT_3
{
    using System;

    // Base class with a protected method
    public class MyBaseClass2
    {
        protected void ProtectedMethod()
        {
            Console.WriteLine("This is a protected method in MyBaseClass.");
        }
    }

    // Derived class that accesses the protected method
    public class MyDerivedClass2 : MyBaseClass
    {
        public void AccessProtectedMethod()
        {
            Console.WriteLine("Calling protected method from MyDerivedClass...");
            ProtectedMethod();
        }
    }

    class Program9
    {
        static void Main(string[] args)
        {
            MyDerivedClass2 derivedInstance = new MyDerivedClass2();

            // Call the public method in MyDerivedClass, which accesses the protected method in MyBaseClass
            derivedInstance.AccessProtectedMethod();
            Console.ReadKey();
        }
    }

}
