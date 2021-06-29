using System;
using System.Collections.Generic;

namespace CheckList
{
    public class ToDo
    {
        public static List<ToDoList> Check { get; set; } = ToDoListStorage.ToDoLists;
        
        public static void Add(string item)
        {
            int count = Check.Count; //checks the number of elements in the list
            int serialNo = count + 1; //set the serialNo value of new item to count + 1

            ToDoList toDoObj = new ToDoList(serialNo, item);// create new object of the ToDOlist class 
            Check.Add(toDoObj); //add the new item to the list.
        }

        public static void Remove(int index)
        {
            ToDoList toDoObj = Check[index - 1];
            Console.Write($"Do you want to remove the item: '{toDoObj.ObjName()}' from the list 'yes/no': ");
            string userAnswer = Console.ReadLine();
            userAnswer.ToLower();
            if (userAnswer == "yes" || userAnswer == "y") Check.RemoveAt(index - 1);
        }

        public static void CheckItem(int index)
        {
            ToDoList toDoObj = Check[index - 1];
            Console.Write($"Do you want to check this item: '{toDoObj.ObjName()}'  'yes/no': ");
            string userAnswer = Console.ReadLine();
            userAnswer.ToLower();
            if (userAnswer == "yes" || userAnswer == "y") toDoObj.isDone = true;
        }

        public static void PrintList()
        {
            Console.Clear();
            foreach (ToDoList item in Check) item.Print();
        }
    }
}
