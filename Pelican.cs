using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class Pelican:Bird
    {
        string length { get; set; }
        public string FLand { get; }
        public Pelican (int w, string n, int a, int wing, string fl) : base(w, n, a, wing)
        { this.FLand = fl; }

        public override string DoSound()
        { return " I am Pelican"; }
    }
}

