using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectDSA
{
    internal class Node
    {
        public string Name { get; set; }
        public Point Location { get; set; } // X, Y coordinates for the UI
        public int CrimeCount { get; set; }
        public Color AreaColor { get; set; } = Color.LightBlue; // Default
    }
}
