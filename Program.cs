using System;

namespace interface_project
{
    class Program
    {
        static void Main(string[] args)
        {
            var marine = new Marines();
            marine.name = "Leroy Jethro Gibbs";
            marine.rank = "Lieutenant";
            marine.serialNumber = 871020079;

            Console.WriteLine($"I am {marine.rank} {marine.name}, Serial Number {marine.serialNumber}");

            Console.WriteLine(marine.Speak());
            Console.WriteLine(marine.Eat());
            Console.WriteLine(marine.Walk());

            Console.WriteLine(marine.Load());
            Console.WriteLine(marine.Aim());
            Console.WriteLine(marine.PullTrigger());

            Console.WriteLine(marine.Sleep());
        }
    }
}
