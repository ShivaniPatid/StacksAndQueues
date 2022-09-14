using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chosse a option\n 1 . Push the elements in the stack");
            int option=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (option)
            {
                case 1:
                    StackPushOperation stack1 = new StackPushOperation();
                    stack1.Push(70);
                    stack1.Push(30);
                    stack1.Push(56);
                    stack1.Display();
                    break;
                default:
                    Console.WriteLine("Choose a appropriate option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
