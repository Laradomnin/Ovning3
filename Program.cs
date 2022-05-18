using System;

namespace Ovning3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pers = new Person();
            var pers1 = new Person("Lisa",65, 70 );

            Console.WriteLine(pers1.PrintPerson());
            Console.WriteLine(pers.PrintPerson());
        }
    }
}
