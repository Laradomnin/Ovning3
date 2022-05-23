using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    public class Dog : Animal
    {

        protected string ras;

        public Dog(int w, string n, int a, string r) : base(w, n, a)
        { this.ras = r; }

        public override string DoSound ()
        {
            var mySound = "WOF WOF";
            return (mySound);  
            //throw new NotImplementedException();
        }
    }

}

