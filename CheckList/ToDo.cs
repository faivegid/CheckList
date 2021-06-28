using System;
using System.Collections.Generic;

namespace CheckList
{
    public class ToDo
    {
        public static void Add(List<ToDoList> list, string item)
        {
            int count = list.Count; //checks the number of elements in the list
            int serialNo = count + 1; //set the serialNo value of new item to count + 1

            ToDoList toDOObj = new ToDoList(serialNo, item);// create new object of the ToDOlist class 
            list.Add(toDOObj); //add the new item to the list.
        }

        public static void Remove(List<ToDoList> list, int index)
        {
            ToDoList toDoObj = list[index - 1];
            Console.Write($"Do you want to remove the item: '{toDoObj.ObjName()}' from the list 'yes/no': ");
            string userAnswer = Console.ReadLine();
            userAnswer.ToLower();


            if (userAnswer == "yes" || userAnswer == "y") list.RemoveAt(index - 1);
        }

        public static void CheckItem(List<ToDoList> list, int index)
        {
            ToDoList toDoObj = list[index - 1];
            Console.Write($"Do you want to check this item: '{toDoObj.ObjName()}'  'yes/no': ");
            string userAnswer = Console.ReadLine();
            userAnswer.ToLower();

            if (userAnswer == "yes" || userAnswer == "y") toDoObj.isDone = true;

        }

        public static void PrintList(List<ToDoList> list)
        {
            foreach (ToDoList item in list) item.Print();
        }
    }
}
