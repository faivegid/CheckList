using System;
using System.Collections.Generic;
using System.Text;

namespace CheckList
{
    public static class ProcessToDo
    {
        public static void PrintOptions()
        {
            Console.WriteLine("\nType 1 Add Item to ChecList");
            Console.WriteLine("Type 2 Remove Item from CheckList");
            Console.WriteLine("Type 3 Check an Item on the List");
            Console.WriteLine("Type 4 Print all Item on Lsit");
            Console.WriteLine("Type 'quit' or 'exit' to stop app\n");
            Console.Write("Input Selection: ");
        }
        public static string UserInput(string str)
        {
            Console.Write(str);
            return Console.ReadLine();
        }
    }
}
