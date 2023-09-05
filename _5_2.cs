using LAB_ASSIGNMENT_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using LAB_ASSIGNMENT_3;


class Program5
{
    static void Main5(string[] args)
    {
        MyClass1 myClass = new MyClass1();

        // Access the protected internal member from AssemblyB
        int value = myClass.protectedInternalField;
        System.Console.WriteLine($"Accessed protected Internal Field from AssemblyB: {value}");
        Console.ReadKey();
    }
}
