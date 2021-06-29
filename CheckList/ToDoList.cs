using System;

namespace CheckList
{
    public class ToDoList
    {
        public int serialNo { get; }
        public string itemName { get; }
        public bool isDone { get; set; } = false;

        public ToDoList(int serialNo, string itemName)
        {
            this.serialNo = serialNo;
            this.itemName = itemName;
        }

        public string ObjName() { return itemName; }

        public void Print() 
        {
            string print = $"| {serialNo} |      {itemName}:      |  {isDone}  |";

            for (int i = 0; i < print.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            Console.WriteLine(print);

            for (int i = 0; i < print.Length; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine();
        }
    }
}
