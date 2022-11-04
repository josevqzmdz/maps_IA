using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maps_IA
{
    public class vertex
    {
        public node first { get; set; }
        public node end { get; set; }
        public int distance { get; set; }
        public string distanceNeighbor { get; set; }
        public vertex(node first, node end, int distance)
        {
            this.first = first;
            this.end = end;
            this.distance = distance;
            this.distanceNeighbor = first.name + " - " + end.name + " = " + distance.ToString();
        }
    }
}
