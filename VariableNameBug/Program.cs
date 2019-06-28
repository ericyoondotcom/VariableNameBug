
using System;
using System.Collections.Generic;

namespace VariableNameBug
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Stack = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine(Stack.GetType());
            //System.Int32[]
            //This proves that the variable Stack is definitely an int array

            System.Diagnostics.Debugger.Break();
            //However, on debug, instead of showing useful info, hovering over Stack shows:
            //error CS0234: The type or namespace name 'Stack' does not exist in the namespace 'System.Collections.Generic' (are you missing an assembly reference?)

            //The debugger seems to prefer the class Stack, imported from System.Collections.Generic
            //However, C# correctly uses the local variable
        }
    }
}
