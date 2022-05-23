using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class Wolf:Animal
    {
        protected string EyeColor;
        public string Food { get; set; }

        public Wolf (int w, string n, int a, string ec) : base(w, n, a)
        { this.EyeColor = ec; }

        public override string DoSound()
        {
            throw new NotImplementedException();
        }
    }
}

