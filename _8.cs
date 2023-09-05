using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//8.Develop a class with a private method. Provide a public method that calls the private method.
namespace LAB_ASSIGNMENT_3
{
    using System;

    public class MyClass4
    {
        // Private method
        private void PrivateMethod()
        {
            Console.WriteLine("This is a private method.");
        }

        // Public method that calls the private method
        public void CallPrivateMethod()
        {
            Console.WriteLine("Calling the private method...");
            PrivateMethod();
        }
    }

    class Program8
    {
        static void Main(string[] args)
        {
            MyClass4 myObject = new MyClass4();

            // Call the public method, which in turn calls the private method
            myObject.CallPrivateMethod();
            Console.ReadKey();
        }
    }

}
