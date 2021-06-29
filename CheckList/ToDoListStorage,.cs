using System;
using System.Collections.Generic;
using System.Text;

namespace CheckList
{
    public static class ToDoListStorage
    {
        public static List<ToDoList> ToDoLists { get; set; } = new List<ToDoList>();
    }
}
