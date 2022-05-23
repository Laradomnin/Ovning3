using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class Worm:Animal

    {

        protected bool isPoisoned;

        public Worm (int w, string n, int a, bool p) : base(w, n, a)
        { this.isPoisoned = p; }

        public override string DoSound()
        {
            var mySound = "sh-sh-sh";
            return (mySound);
            //throw new NotImplementedException();
        }
    }
}

