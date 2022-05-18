using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class Person
    {
        private string fName;
        private string lName;
        private int height;
        private int weight;
        private int age;
        public int Height {
            get { return height; }
            set { height = value; }
        }
        public int Weight {
            get { return weight; }
            set { weight = value; }
        }
        public string FName
        {
            get { return fName; }
            set
            {  // validera input
                if (string.IsNullOrEmpty(value))
                {
                    // exception
                    throw new ArgumentException(" Namn är obligatorisk !");

                }
                fName = value; }
        }
        public string LName {
            get { return lName; }
            set { lName = value; }
        }
        public int Age {
            get { return age; }
            set { age = value; }
        }
        //Constructor:
        public Person()
        {
        }
        // Constructor:
        public Person(string n, int a, int w)
        {
            FName = n;
            Age = a;
            Weight = w;
        }
        // Printing method:
        
        
        public string PrintPerson()
        {
         return string.Format("{0}, {1} years old, {2}.", fName, age, weight);
        }

    }
}
