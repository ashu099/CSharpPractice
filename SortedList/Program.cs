using System;
using System.Collections.Generic;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedList<int, string> nameNumbers = new SortedList<int, string>();
            nameNumbers.Add(1, "one");
            nameNumbers.Add(5, "five");
            nameNumbers.Add(2, "Two");
            //bydefault above values are sorted by assending order

            nameNumbers.Add(6, null);// allowed because in sortedlist values can be dulicate and null
         // nameNumbers.Add(6, "four");//runtiome error because keys can not be duplicate
         // nameNumbers.Insert(1, "one");//insert not possible
            nameNumbers.Remove(2);
            nameNumbers.RemoveAt(1);//removes value and key from index whose value is 1
            Console.WriteLine("Hello World!");
        }
    }
}
