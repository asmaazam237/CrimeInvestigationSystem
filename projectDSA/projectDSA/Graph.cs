using projectDSA;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectDSA
{
    internal class Graph
    {
        public static List<Node> GetNodes()
        {           
            return new List<Node>
            {
                new Node { Name = "Gulistan-e-Jauhar", Location = new Point(80, 180), AreaColor = Color.DarkSeaGreen },
                new Node { Name = "Malir", Location = new Point(80, 380), AreaColor = Color.DarkSeaGreen },
                new Node { Name = "Shah Faisal Colony", Location = new Point(180, 280), AreaColor = Color.DarkSeaGreen },
                new Node { Name = "Korangi", Location = new Point(350, 420), AreaColor = Color.DarkSeaGreen },
                new Node { Name = "Clifton", Location = new Point(280, 240), AreaColor = Color.DarkSeaGreen },
                new Node { Name = "DHA", Location = new Point(250, 160), AreaColor = Color.DarkSeaGreen },
                new Node { Name = "Kharadar", Location = new Point(450, 320), AreaColor = Color.DarkSeaGreen },
                new Node { Name = "Saddar", Location = new Point(480, 220), AreaColor = Color.DarkSeaGreen },
                new Node { Name = "Gulshan-e-Iqbal", Location = new Point(400, 100), AreaColor = Color.DarkSeaGreen },
                new Node { Name = "North Nazimabad", Location = new Point(550, 100), AreaColor = Color.DarkSeaGreen },
                new Node { Name = "Nazimabad", Location = new Point(580, 220), AreaColor = Color.DarkSeaGreen },
                new Node { Name = "Orangi Town", Location = new Point(720, 240), AreaColor = Color.DarkSeaGreen }
            };
        }
        public static List<Edge> GetEdges()
        {
            return new List<Edge>
            {
                new Edge { From = "Clifton", To = "Saddar", Distance = 8 },
                new Edge { From = "Clifton", To = "Kharadar", Distance = 10 },
                new Edge { From = "Clifton", To = "DHA", Distance = 6 },
                new Edge { From = "Clifton", To = "Gulshan-e-Iqbal", Distance = 15 },
                new Edge { From = "Saddar", To = "Kharadar", Distance = 3 },
                new Edge { From = "Saddar", To = "Gulshan-e-Iqbal", Distance = 13 },
                new Edge { From = "Saddar", To = "North Nazimabad", Distance = 15 },
                new Edge { From = "Saddar", To = "Nazimabad", Distance = 11 },
                new Edge { From = "Kharadar", To = "Korangi", Distance = 20 },
                new Edge { From = "Korangi", To = "Shah Faisal Colony", Distance = 8 },
                new Edge { From = "Shah Faisal Colony", To = "Gulistan-e-Jauhar", Distance = 9 },
                new Edge { From = "Gulistan-e-Jauhar", To = "Gulshan-e-Iqbal", Distance = 6 },
                new Edge { From = "Gulshan-e-Iqbal", To = "North Nazimabad", Distance = 10 },
                new Edge { From = "Nazimabad", To = "North Nazimabad", Distance = 4 },
                new Edge { From = "Orangi Town", To = "North Nazimabad", Distance = 7 },
                new Edge { From = "Orangi Town", To = "Nazimabad", Distance = 6 },
                new Edge { From = "Malir", To = "Shah Faisal Colony", Distance = 10 },
                new Edge { From = "Malir", To = "Gulistan-e-Jauhar", Distance = 12 },
                new Edge { From = "Malir", To = "Korangi", Distance = 14 }
            };
        }
    }
}
