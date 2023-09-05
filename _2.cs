using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2.Design a class with a public method that accesses a private field from another class in the same assembly.
namespace LAB_ASSIGNMENT_3
{


    // First class in the same assembly with a private field
    public class FirstClass
    {
        private int privateField = 42;

        // Internal accessor to allow access from the same assembly
        internal int GetPrivateField()
        {
            return privateField;
        }

        // Constructor for demonstration purposes
        public FirstClass()
        {
            // Initialize the private field
            privateField = 40;
        }
    }

    // Second class that accesses the private field from the first class
    public class SecondClass
    {
        public void AccessPrivateField(FirstClass firstClassInstance)
        {
            // Access the private field from the first class using the internal accessor
            int value = firstClassInstance.GetPrivateField();
            Console.WriteLine("Accessed privateField from SecondClass: " + value);
        }
    }

    class Program
    {
        static void Main3(string[] args)
        {
            FirstClass firstInstance = new FirstClass();
            SecondClass secondInstance = new SecondClass();

            // Call the public method of SecondClass to access the private field of FirstClass
            secondInstance.AccessPrivateField(firstInstance);
            Console.ReadKey();
        }
    }


}
