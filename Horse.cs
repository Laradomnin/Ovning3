using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    public class Horse : Animal
    {

        protected string ras { get; set; }

        public Horse (int w, string n, int a,string r) : base(w, n, a)
        { this.ras = r;}

        public override string DoSound()
        {
            return"gnääh";
        }
        public override string Stats()
        {
            return base.Stats() + $"{ras}";
        }
    }
    
    }

