using System;
using System.Collections.Generic;

namespace EqualsVsDotEquals
{
    class Program
    {
        public class student
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            string s = "abc"; // 101
            object t = new string("abc");//1002
            Console.WriteLine(s == t);//== checks the object reference wherease Equals checks the contents
            Console.WriteLine(s.Equals(t));/// 

            //Exception
            string s1 = "a";
            string s2 = "a";
            string s3 = new string(s2);

            Console.WriteLine(s1 == s2);
            Console.WriteLine(s3 == s1);



            //CASE:- 1
            List<int> l = new List<int>();
            l.Add(1);
            //  l.Add("a");//not allowed because l is strongly typed of type Integer and
            //here we are trying to add a string element
            // l.Add(null);//null is not allowed to because l is of value type and we can not assign null to non-nullable value type;

            //CASE :- 2
            List<string> str = new List<string>();
            str.Add("a");
            str.Add(null);//this is allowed because string is reference type and we can assign null to reference type
            //str.Add('a');  // not allowed because here str is strongly typed of string and we can not add char or any other type to string
            //str.Add(1);

            var students = new List<student>()
            { new student{ Id=1,Name="ashutosh"}, new student{ Id=2,Name="Rahul"}, new student{ Id=2,Name="Abhishek"}, new student{ Id=2,Name="Vinod"},
            new student{ Id=2,Name="Rahul"} };

            //Adding array to list
            string[] stringarray = new string[3] { "Satna", "Rewa", "Jabalpur" };
            var listOne = new List<string>();
            listOne.AddRange(stringarray);
            var listTwo = new List<string>();
            listTwo.AddRange(listOne);
            foreach (var item in listTwo)
            {
                Console.WriteLine(item);
            }


            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            numbers.Insert(0, 0);
            numbers.Contains(20);

            var es = new StudentSearch("A");
            Console.WriteLine("'A' starts at index {0}", students.FindIndex(1, students.Count - 1, es.StartsWith));
            //Console.WriteLine("'A' starts at index {0}", students.FindLast(es.StartsWith));
            Console.Read();
        }
        public class StudentSearch
        {
            String _s;

            public StudentSearch(String s)
            {
                _s = s;
            }

            public bool StartsWith(student e)
            {
                return e.Name.StartsWith(_s, StringComparison.InvariantCultureIgnoreCase);
            }
        }

    }
}
