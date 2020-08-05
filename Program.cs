using System;

namespace openshift_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            System.IO.File.WriteAllText("/data/test.txt", "Test");

            Console.WriteLine(System.IO.File.ReadAllText("/data/test.txt"));
            Console.WriteLine("END!");
        }
    }
}
