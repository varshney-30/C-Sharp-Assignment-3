using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.CompilerServices;

//5.Develop a class with a protected internal member and
//create an instance in a different assembly to access it.
namespace LAB_ASSIGNMENT_3
{
//[assembly: InternalsVisibleTo("AssemblyB")]


        public class MyClass1
        {
            protected internal int protectedInternalField = 42;
        }
 }


