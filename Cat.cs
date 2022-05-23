using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    public class Cat : Animal
    {

        protected string color;

        public Cat (int w, string n, int a, string c) : base(w, n, a)
        { this.color = c; }

        public override string DoSound()
        {
            throw new NotImplementedException();
        }
    }

}