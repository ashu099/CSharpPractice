using System;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(1);
            callerIds.Enqueue(3);
            callerIds.Enqueue(2);
            // callerIds.Enqueue("a");//not allowed
            callerIds.Enqueue(5);
            //callerIds.Enqueue(null);//not allowed
            foreach (var item in callerIds)
            {
                Console.WriteLine(item);//o/p 1,3,2,5

            }
            
            Console.WriteLine(callerIds.Count);//output 4


            //Deque example
            Queue<string> test = new Queue<string>();
            test.Enqueue("H");
            test.Enqueue("E");
            test.Enqueue("L");
            test.Enqueue("L");
            test.Enqueue("O");

            Console.WriteLine(test.Peek());//Returns top element from queue
            Console.WriteLine(test.Contains("E"));// returns true if E is present in queue
            while (test.Count > 0)
                Console.Write(test.Dequeue());// HELLO  once we call dequeue it returns the element and same time it removes from queue

            callerIds.Clear();//clears queue
            Console.Read();
        }
    }
}
