using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_lb4
{
    public class PUBs 
    {
        public string name { get; set; }
        public PUBs() {}
        public PUBs(string Name) { name = Name; }

        public override string ToString()
        {
            return name;
        }
    }
}
