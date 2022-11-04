using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maps_IA
{
    public class node
    {
        public string name { get; set; }
        public node(string name)
        {
            this.name = name;
            neighbor = new List<node>();
            vertexes = new List<vertex>();
        }
        public List<node> neighbor { get; set; }
        public List<vertex> vertexes { get; set; }
        public int distance { get; set; }
    }
}
