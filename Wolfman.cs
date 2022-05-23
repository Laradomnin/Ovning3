using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3

{
    class Wolfman : Wolf, IPerson
    {
        public Wolfman(int w, string n, int a, string ec) : base(w, n, a,ec)
        {

        }
       
        public string Talk()
        {
            return $"hggf"; 
         }
    }
}