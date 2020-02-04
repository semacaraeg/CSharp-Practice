using System;
using System.Threading.Tasks;
using System.Threading;

namespace ProgramFlow
{
    class Program
    {
        //Parallel Invoke
        static void Task1(){
            Console.WriteLine("Task 1 starting");
            Thread.Sleep(2000);
             Console.WriteLine("Task 1 ending");
        }
         static void Task2(){
            Console.WriteLine("Task 2 starting");
            Thread.Sleep(1000);
             Console.WriteLine("Task 2 ending");
        }

        static void Main(string[] args)
        {
            Parallel.Invoke(()=>Task1(), ()=>Task2());
            Console.WriteLine("Finished processing. Pressed any key to end.");
            Console.ReadKey();
        }

        static void WorkOnItem(Object item){
            Console.WriteLine("Started working on: " + item);
            Thread.Sleep(100);
             Console.WriteLine("Finished working on: " + item);
        }
    }
}
