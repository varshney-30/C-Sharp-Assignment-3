using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

//10.Build a class with an internal constructor and create an instance from another assembly.
namespace LAB_ASSIGNMENT_3
{
    

//[assembly: InternalsVisibleTo("AssemblyB")]


    
        public class MyClass10
        {
            // Internal constructor
            internal MyClass10()
            {
                // Constructor logic here
            }

            public void MyMethod()
            {
                Console.WriteLine("MyMethod called.");
            }
        }
    }

