using System;
using System.Collections.Generic;
namespace Ovning3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pers = new Person();
            var pers1 = new Person("Ericson",65, 70 );
            var cat1 = new Cat(5, "Pigelin", 7, "Svart");

            Console.WriteLine(pers1.PrintPerson());
            Console.WriteLine(pers.PrintPerson());
            Console.WriteLine(cat1.Stats());

            var UserErrors = new System.Collections.Generic.List<UserError>
            { new NumericInputError(),
              new TextInputError()
            };
                 
            foreach (var error in UserErrors) {Console.WriteLine(error.UEMessage()); }   
        }

    }
}
