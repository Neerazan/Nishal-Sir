using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Task
    {
        public string Name;
        public bool IsCompleted;

        public Task(string name)
        {
            this.Name = name;
            this.IsCompleted = false;
        }
        public void MarkAsComplete()
        {
            this.IsCompleted = true;
            Console.WriteLine("This task is completed. Thank you!");
        }

        public void MarkAsInComplete()
        {
            this.IsCompleted = false;

        }

    }
}
