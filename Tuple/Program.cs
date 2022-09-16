using System;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8);


            Console.WriteLine(numbers.Item1);
            Console.WriteLine(numbers.Item2);
            Console.WriteLine(numbers.Item3);
            Console.WriteLine(numbers.Item4);
            Console.WriteLine(numbers.Item5);
            Console.WriteLine(numbers.Item6);
            Console.WriteLine(numbers.Item7);
            Console.WriteLine(numbers.Rest);
            Console.WriteLine(numbers.Rest.Item1);

            Console.ReadLine();
        }
    }
}
