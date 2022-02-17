using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multitask_asynchronous
{
    class Program
    {
        private static void CreateTaskUsingAction()
        {
            Console.WriteLine("This Task is created using Action.\n");
        }
        private static void CreateTaskUsingDelegate()
        {
            Console.WriteLine("This Task is created using Delegate.\n");
        }
        private static void CreateTaskUsingLambdaAndNamedMethod()
        {
            Console.WriteLine("This Task is created using Lambda and Named Method.\n");
        }
        private static void CreateTaskUsingLambdaAndAnonymousMethod()
        {
            Console.WriteLine("This Task is created using Lambda and Anonymous Method.\n");
        }

        private static void CreateTaskUsingAsyncAwait()
        {
            Console.WriteLine("This Task is created using Async and Await.\n");
        }

        private static async void CreateAsyncTask()
        {
            await Task.Run(() => CreateTaskUsingAsyncAwait());
        }

        private static int Add(int a, int b)
        {
            return a + b;
        }

        private static async void SolveTheMath(int firstInt, int secondtInt)
        {
            int result = await Task.FromResult(Add(firstInt, secondtInt));
            await Task.Delay(1000);
            Console.WriteLine("Result = " + result.ToString());
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Seven ways to start a Task in C# .NET:");
            Console.WriteLine("========================\n");
            Task.Factory.StartNew(() => { Console.WriteLine("This Task is created using Factory Method.\n"); });
            Task actionTask = new Task(new Action(CreateTaskUsingAction));
            actionTask.Wait(1000);
            actionTask.Start();

            Task delegateTask = new Task(delegate { CreateTaskUsingDelegate(); });


        }
    }
}
