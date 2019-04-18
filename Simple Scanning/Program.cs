using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var quit = false;
            var tasks = new List<Tasking>();
            var docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            // Load the list from a file HERE
            try
            {
                StreamReader tl = new StreamReader("C:\\Test.txt");
                {
                    foreach (var newTask in tasks)
                    {//Read the first line of text
                        tasks = tl.ReadLine();
                    }
                }

                do
                {
                    Control.PrintMainMenu();
                    // If we clear here, we'll need to ask for input after displaying list
                    Console.Write("Select your item:");
                    var input = Console.ReadLine();

                    quit = Control.HandleInput(tasks, input);
                } while (!quit);

                // Save the list to a file here
                StreamWriter tl = new StreamWriter("C:\\Test.txt"))
                foreach (var newTask in tasks)
                {
                    tl.WriteLine(tasks);
                }
                    tl.Close();
            }
            

        }
    }
}


