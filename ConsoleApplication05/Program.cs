using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication05
{
    class Program
    {
        static void Main(string[] args)
        {
            var taskList = new List<System.Threading.Tasks.Task>();
            var list = new List<int>() { 0, 1, 2, 3 };
            Parallel.For(0, list.Count, i =>
            {
                Task taskTemp =Task.Factory.StartNew(() => { });
                taskList.Add(taskTemp);
            });

            Task.WaitAll(taskList.ToArray());

            taskList.Clear();
            Console.ReadKey();
        }
    }
}
