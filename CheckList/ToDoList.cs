using System;

namespace CheckList
{
    public class ToDoList
    {
        private int serialNo;
        private string itemName;
        public bool isDone { get; set; } = false;

        public ToDoList(int serialNo, string itemName)
        {
            this.serialNo = serialNo;
            this.itemName = itemName;
        }

        public string ObjName() { return itemName; }

        public void Print() { Console.WriteLine($"{serialNo} {itemName}: {isDone}"); }
    }
}
