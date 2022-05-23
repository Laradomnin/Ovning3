using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class Bird:Animal
    {
        protected int wingspan;

        public Bird (int w, string n, int a, int wing) : base(w, n, a)
        { this.wingspan = wing; }

        public override string DoSound()
        {
            throw new NotImplementedException();
        }
    }

}

