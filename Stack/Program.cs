using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> mystack = new Stack<int>();
            mystack.Push(1);
            mystack.Push(2);
            mystack.Push(3);
            mystack.Push(4);
            mystack.Push(5);

            foreach (var item in mystack)
            {
                Console.WriteLine(item);
            }

            //add array to stack 
            int[] arr = new int[3] { 1, 2, 3 };
            Stack<int> anotherstack = new Stack<int>(arr);

            foreach (var item in anotherstack)
            {
                Console.WriteLine(item);
            }
            //peek
            Console.WriteLine("peek value:{0}",mystack.Peek());
            //contains
            Console.WriteLine(" mystack contains 2 :{0}",mystack.Contains(2));
            //pop
            Console.WriteLine("No of element in stack before pop:{0}", anotherstack.Count);
            while (anotherstack.Count>0)
            {
                Console.WriteLine( anotherstack.Pop());
            }
            Console.WriteLine("No of element in stack after pop:{0}", anotherstack.Count);
            Console.WriteLine("Hello World!");
        }
    }
}
