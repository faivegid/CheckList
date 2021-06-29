using System;
using System.Collections.Generic;
using System.Text;

namespace CheckList
{
    public static class Validation
    {
        public static int ReturnInt(string value)
        {
            int index = 0;
            try
            {
                index = int.Parse(value);                
            }
            catch
            {
                Console.WriteLine("Invalid Selection");
            }
            return index;
        }
    }
}
