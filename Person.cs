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
        private double weight;
        private int age;
       
        //Constructor:
        public Person()
        {
        }
        // Constructor2:
        public Person(string n, int a, double w)
        {
            FName = n;
            Age = a;
            Weight = w;
        }
        public int Height {
            get { return height; }
            set { height = value; }
        }
        public double Weight {
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
                    // c exception
                    throw new ArgumentException(" Namn är obligatorisk !");

                }
                fName = value; }
        }
        public string LName {
            get { return lName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Kan ej lämnas tomt");
                if (value.Length > 10 || value.Length< 2)
                    throw new ArgumentOutOfRangeException("Det skall vara minst 2 och högst 10 tecken");
                lName = value;
            }
            
        }
        public int Age {
            get { return age; }
            set { age = value; }
        }
        
        // Printing method:
        
        
        public string PrintPerson()
        {
         return string.Format("Person: {0}, är {1} år, väger {2} .", fName, age, weight);
        }

    }
}
