using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.Create a class with a private field and a public method to set its value.
namespace LAB_ASSIGNMENT_3
{
    
    public class _1
    {
        private int myPrivateField;

        // Public method to set the value of the private field
        public void SetValue(int newValue)
        {
            myPrivateField = newValue;
        }

        // Public method to get the value of the private field (optional)
        public int GetValue()
        {
            return myPrivateField;
        }
    }

    class Program2
    {
        static void Main2(string[] args)
        {
            _1 myObject = new _1();

            // Set the value of the private field using the public method
            myObject.SetValue(42);

            // Get the value of the private field using the public method
            int value = myObject.GetValue();

            Console.WriteLine("The value of myPrivateField is: " + value);
            Console.ReadKey();
        }
    }

}
