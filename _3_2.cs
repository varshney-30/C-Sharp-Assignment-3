using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// AssemblyB.cs
using LAB_ASSIGNMENT_3;


class Program3
{
    static void Main3(string[] args)
    {
        MyClass myClass = new MyClass();

        // Access the internal field and method from AssemblyA
        Console.WriteLine($"Accessed Internal Field from AssemblyB: {myClass.myInternalField}");
        myClass.DisplayInternalField();
        Console.ReadKey();
    }
}

