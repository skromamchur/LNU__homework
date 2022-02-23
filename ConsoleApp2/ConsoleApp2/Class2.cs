using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Collection
    {
        public List<int> elements { get; set; }

        public Collection() { 
            this.elements = new List<int>();
        }
    }
}
