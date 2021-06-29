using System;
using System.Collections.Generic;

namespace CheckList
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = ProcessToDo.UserInput("Do you want to create a CheckList: 'yes/no': ");
            
            if (userInput == "yes" || userInput == "y")
            {
                while (true)
                {
                    ProcessToDo.PrintOptions();                    
                    userInput = Console.ReadLine();
                    userInput = userInput.ToLower();
                    if (userInput == "exit" || userInput == "quit") break;
                    
                    int index;

                    switch (userInput)
                    {
                        case "1":
                            while (true)
                            {
                                ToDo.PrintList();
                                ToDo.Add(ProcessToDo.UserInput("input todo Item name: "));
                                ToDo.PrintList();                                                                
                                string strAns = ProcessToDo.UserInput("Do you want to add another item 'yes/no': ").ToLower();
                                if (strAns == "yes" || strAns == "y") { continue; }
                                else { break; }                                    
                            }                            
                            break;
                        case "2":
                            ToDo.PrintList();                            
                            index = Validation.ReturnInt(ProcessToDo.UserInput("input Item Id to remove it: "));
                            ToDo.Remove(index);
                            break;
                        case "3":
                            ToDo.PrintList();                            
                            index = Validation.ReturnInt(ProcessToDo.UserInput("Select todo Item to mark done: "));
                            ToDo.CheckItem(index);
                            break;
                        case "4":
                            ToDo.PrintList();
                            break;
                        default:
                            break;
                    }                    
                }
            }

            Console.WriteLine();
            Console.Write("Exiting the CheckList App........\n");
        }        
    }
}
