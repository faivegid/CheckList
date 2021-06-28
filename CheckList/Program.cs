using System;
using System.Collections.Generic;

namespace CheckList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Do you want to create a CheckList: 'yes/no': ");
            string userInput = Console.ReadLine();
            userInput = userInput.ToLower();

            if (userInput == "yes" || userInput == "y")
            {
                List<ToDoList> checkList = new List<ToDoList>();

                while (true)
                {
                    PrintOptions();

                    Console.Write("Input Selection: ");
                    userInput = Console.ReadLine();
                    userInput = userInput.ToLower();
                    if (userInput == "exit" || userInput == "quit") break;
                    string userAns = "";

                    switch (userInput)
                    {
                        case "1":
                            Console.Clear();
                            ToDo.PrintList(checkList);
                            Console.Write("input todo Item name: ");
                            userAns = Console.ReadLine();
                            ToDo.Add(checkList, userAns);
                            ToDo.PrintList(checkList);
                            break;
                        case "2":
                            Console.Clear();
                            ToDo.PrintList(checkList);
                            Console.Write("input todo Item name: ");
                            userAns = Console.ReadLine();
                            ToDo.Add(checkList, userAns);
                            break;
                        case "3":
                            Console.Clear();
                            ToDo.PrintList(checkList);
                            Console.Write("Select todo Item to mark done: ");
                            userAns = Console.ReadLine();
                            int index = 0;
                            try
                            {
                                index = int.Parse(userAns);
                                if (index > checkList.Count) break;
                            }
                            catch
                            {
                                Console.WriteLine("Invalid Selection");
                            }

                            Console.Write($"Do Want to mark {checkList} this as Done yes/no: ");
                            userAns = Console.ReadLine();

                            if (userAns == "yes" || userAns == "y")
                            {
                                ToDo.CheckItem(checkList, index);
                            }
                            break;
                        case "4":
                            Console.Clear();
                            ToDo.PrintList(checkList);
                            break;
                        default:
                            break;
                    }                    
                }
            }

            Console.Write("Exiting the CheckList App........\n");
        }

        static void PrintOptions()
        {
            Console.WriteLine("\nType 1 Add Item to ChecList");
            Console.WriteLine("Typpe 2 Remove Item from CheckList");
            Console.WriteLine("Type 3 Check an Item on the List");
            Console.WriteLine("Type 4 Print all Item on Lsit");
            Console.WriteLine("Type 'quit' or 'exit' to stop app\n");
        }
    }
}
