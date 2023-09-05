using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//7.Build a class with a private property and provide
//a public method to modify its value. Test the functionality.
namespace LAB_ASSIGNMENT_3
{
    using System;

    public class MyClass3
    {
        private int privateProperty;

        // Constructor to initialize the private property
        public MyClass3(int initialValue)
        {
            privateProperty = initialValue;
        }

        // Public method to modify the private property's value
        public void SetPrivatePropertyValue(int newValue)
        {
            privateProperty = newValue;
        }

        // Public method to get the private property's value
        public int GetPrivatePropertyValue()
        {
            return privateProperty;
        }
    }

    class Program7
    {
        static void Main(string[] args)
        {
            // Create an instance of MyClass
            MyClass3 myObject = new MyClass3(10);

            // Get the initial value of the private property
            int initialValue = myObject.GetPrivatePropertyValue();
            Console.WriteLine($"Initial Value: {initialValue}");

            // Use the public method to modify the private property's value
            myObject.SetPrivatePropertyValue(42);

            // Get the updated value of the private property
            int updatedValue = myObject.GetPrivatePropertyValue();
            Console.WriteLine($"Updated Value: {updatedValue}");
            Console.ReadKey();
        }
    }

}
