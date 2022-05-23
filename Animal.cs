using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    public abstract class Animal
    {
        public int weight { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public Animal(int w, string n, int a)
        {
            weight = w;
            name = n;
            age = a;

        }
        public abstract string DoSound();
        public virtual string Stats()
        {
            return $"{weight}, {name}, {age}";
        }
    }
    
}
