using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.CompilerServices;


//3.Implement a class with an internal field and access it from a different assembly.

//To access an internal field of a class from a different assembly in C#, you can use the
//InternalsVisibleTo attribute to allow access to internal members from a specific assembly.
namespace LAB_ASSIGNMENT_3
{
//[assembly: InternalsVisibleTo("AssemblyB")]


        public class MyClass
        {
            internal int myInternalField = 42;

            public void DisplayInternalField()
            {
                Console.WriteLine($"Internal Field Value: {myInternalField}");
            }
        }
 }


