using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Tasking : IEquatable<Tasking>
    {
        public string TaskName { get; set; }

        public int TaskNum { get; set; }

        public override string ToString()
        {
            return TaskNum + ":" + TaskName;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Tasking objAsTask = obj as Tasking;
            if (objAsTask == null) return false;
            else return Equals(objAsTask);
        }
        public override int GetHashCode()
        {
            return TaskNum;
        }
        public bool Equals(Tasking other)
        {
            if (other == null) return false;
            return (this.TaskNum.Equals(other.TaskNum));
        }
        // Should also override == and != operators.


        // Create a data source by using a collection initializer.
        class Tasking
        {

            Console.WriteLine("How many tasks would you like to add?");
        int TotalTaskings = Convert.ToInt32(Console.ReadLine());

        List<Tasking> TaskList = new List<Tasking>();

            for (int index = 0; index<TotalTaskings; index++)
            {
                Console.WriteLine("Type the task you wish to add", index + 1);
                TaskList.Add(new Tasking()
        {
            TaskName = Console.ReadLine(),
                    TaskNum = index
                });
            }
}


