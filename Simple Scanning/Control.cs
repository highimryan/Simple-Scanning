using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class Control
    {
        public static void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Simple Scanning Task Management System\n");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(" 1. Display Task List");
            Console.WriteLine(" 2. Add Task");
            Console.WriteLine(" 3. Cross Task Out");
            Console.WriteLine(" 4. Re-Enter Task");
            Console.WriteLine(" 0. Quit");
        }

        public static bool HandleInput(List<string> tasks, string input)
        {
            // The "quit" handling is a little hinkey(?)
            // The other parameters are passed in automatically by the refactoring tool
            // It's impressive how close it can get to what we intend.

            // We can get rid of all this "quit"

            var quit = false;

            if (input == "0")
            {
                quit = true;
            }
            else if (input == "1")
            {
                Console.Clear();
                // So, that worked. Let's print the list using a 'for' loop
                // Square brackets "into" into an array/list
                // tasks[0] is first item
                // tasks[1] is second item
                // tasks[tasks.Count - 1] is the last
                for (int i = 0; i < tasks.Count; ++i)
                {
                    //Console.WriteLine(tasks[i]);
                    Console.WriteLine($"{i + 1}.{tasks[i]}");
                }

                Console.Write("Press any key to return to main menu...");
                Console.ReadKey();
                
            }
            else if (input == "2")
            {
                // Now, we have a place to store the tasks called ("tasks")
                // Lets provide a prompt:
                Taskings.AddTask();
                Console.Write("Enter your task: ");
                var newTask = Console.ReadLine();
                // Now, add the input task to the list.
                tasks.Add(newTask);
            }
            else if (input == "3")
            {
                Console.WriteLine("Invalid input...Press any key to return to main menu...\n");
                Console.ReadKey();
            }

            return quit;

        }
    }

}
