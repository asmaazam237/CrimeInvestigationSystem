using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectDSA
{
    public partial class RouteMap : Form
    {
        List<Node> nodes = new List<Node>();
        List<Edge> edges = new List<Edge>();
        int[,] adjMatrix = new int[12, 12];
        List<string> shortestPathNodes = new List<string>();
        public RouteMap()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Prevents flickering
            nodes = Graph.GetNodes();
            edges = Graph.GetEdges();
            FillAdjacencyMatrix();
            ApplyGraphColoring();
            lblTotal.Text = "";
        }
        private void FillAdjacencyMatrix()
        {
            for (int i = 0; i < 12; i++)
                for (int j = 0; j < 12; j++)
                    adjMatrix[i, j] = 0;
            foreach (var edge in edges)
            {
                int u = GetNodeIndex(edge.From);
                int v = GetNodeIndex(edge.To);
                if (u != -1 && v != -1)
                {
                    adjMatrix[u, v] = edge.Distance;
                    adjMatrix[v, u] = edge.Distance;
                }
            }
        }
        private int GetNodeIndex(string name)
        {
            for (int i = 0; i < nodes.Count; i++)
                if (nodes[i].Name == name) return i;
            return -1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((cmbSource.SelectedItem == null) || (cmbDest.SelectedItem == null))
            {
                MessageBox.Show("No source and destination is selected!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string source = cmbSource.SelectedItem.ToString();
            string destination = cmbDest.SelectedItem.ToString();

            if (source != destination)
            { FindShortestPath(source, destination); }
            else
            { MessageBox.Show("Source and Destination are the same!, The distance'll be zero.", "NO PATH", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void RouteMap_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            int radius = 10;
            Font labelFont = new Font("Segoe UI", 9, FontStyle.Bold);
            Pen edgePen = new Pen(Color.LightGray, 3);
            Pen highlightPen = new Pen(Color.Red, 5);
            Font distanceFont = new Font("Segoe UI", 8, FontStyle.Bold);
            Brush distanceBrush = Brushes.DarkRed;
            foreach (var edge in edges)
            {
                var fromNode = nodes.Find(n => n.Name == edge.From);
                var toNode = nodes.Find(n => n.Name == edge.To);
                if (fromNode != null && toNode != null)
                {
                    if (shortestPathNodes.Contains(fromNode.Name) && shortestPathNodes.Contains(toNode.Name))
                        g.DrawLine(highlightPen, fromNode.Location, toNode.Location);
                    else
                        g.DrawLine(edgePen, fromNode.Location, toNode.Location);
                    int midX = (fromNode.Location.X + toNode.Location.X) / 2;
                    int midY = (fromNode.Location.Y + toNode.Location.Y) / 2;

                    string distText = edge.Distance.ToString() + " km";
                    SizeF textSize = g.MeasureString(distText, distanceFont);
                    // We use the Form's BackColor to hide the line behind the text
                    g.FillRectangle(new SolidBrush(this.BackColor), midX - (textSize.Width / 2), midY - 10, textSize.Width, textSize.Height);
                    g.DrawString(distText, distanceFont, distanceBrush, midX - (textSize.Width / 2), midY - 10);
                }
            }
            // Draw Nodes (Circles and Labels)
            foreach (var node in nodes)
            {
                // Draw Circle
                using (Brush brush = new SolidBrush(node.AreaColor))
                { g.FillEllipse(brush, node.Location.X - radius, node.Location.Y - radius, radius * 2, radius * 2); }
                g.DrawEllipse(Pens.SteelBlue, node.Location.X - radius, node.Location.Y - radius, radius * 2, radius * 2);
                float textX = node.Location.X + 15;
                float textY = node.Location.Y - 10;
                if (node.Name.Contains("Gulshan-e-Iqbal") || node.Name.Contains("Nazimabad"))
                {
                    textX = node.Location.X - 8;
                    textY = node.Location.Y - 24;
                }
                if (node.Name.Contains("Saddar"))
                {
                    textX = node.Location.X + 10;
                    textY = node.Location.Y + 5;
                }
                if (node.Name.Contains("Orangi Town"))
                {
                    textX = node.Location.X - 20;
                    textY = node.Location.Y - 25;
                }
                g.DrawString(node.Name, labelFont, Brushes.Black, textX, textY);
            }
        }
        private void FindShortestPath(string startName, string endName)
        {
            int n = 12;
            int[] dist = new int[n];
            int[] prev = new int[n];
            bool[] visited = new bool[n];
            for (int i = 0; i < n; i++)
            {
                dist[i] = int.MaxValue;
                prev[i] = -1;
                visited[i] = false;
            }
            int startIdx = GetNodeIndex(startName);
            int endIdx = GetNodeIndex(endName);
            if (startIdx == -1 || endIdx == -1) return;
            dist[startIdx] = 0;
            // Dijkstra Loop
            for (int count = 0; count < n; count++)
            {
                // 1. Find the node with the minimum distance manually
                int u = -1;
                int min = int.MaxValue;
                for (int i = 0; i < n; i++)
                {
                    if (!visited[i] && dist[i] < min)
                    {
                        min = dist[i];
                        u = i;
                    }
                }
                if (u == -1 || u == endIdx) break;
                visited[u] = true;
                // 2. Look at neighbors in the Matrix row
                for (int v = 0; v < n; v++)
                {
                    // If adjMatrix[u,v] > 0, there is a connection
                    if (!visited[v] && adjMatrix[u, v] > 0)
                    {
                        int alt = dist[u] + adjMatrix[u, v];
                        if (alt < dist[v])
                        {
                            dist[v] = alt;
                            prev[v] = u;
                        }
                    }
                }
            }
            // Process and display the results
            DisplayShortestPath(endIdx, prev, dist[endIdx]);
        }
        private void DisplayShortestPath(int endIdx, int[] prev, int totalDist)
        {
            shortestPathNodes.Clear();
            int current = endIdx;
            // If totalDist is MaxValue, it means no path was found
            if (totalDist == int.MaxValue)
            {
                MessageBox.Show("No path exists between these areas.");
                return;
            }
            while (current != -1)
            {
                shortestPathNodes.Add(nodes[current].Name);
                current = prev[current];
            }
            shortestPathNodes.Reverse();
            lblTotal.Text = $"Total Distance: {totalDist} km";
            UpdatePathDisplay();
            this.Invalidate();
        }
        private void UpdatePathDisplay()
        {
            txtPathDetails.Clear();
            for (int i = 0; i < shortestPathNodes.Count - 1; i++)
            {
                string nodeA = shortestPathNodes[i];
                string nodeB = shortestPathNodes[i + 1];
                int d = 0;
                // Manual loop to find the distance between two nodes
                foreach (var edge in edges)
                {
                    if ((edge.From == nodeA && edge.To == nodeB) || (edge.From == nodeB && edge.To == nodeA))
                    {
                        d = edge.Distance;
                        break;
                    }
                }
                txtPathDetails.AppendText(nodeA + " to " + nodeB + ": " + d + " km\r\n");
            }
        }
        private void ApplyGraphColoring()
        {
            foreach (var node in nodes)
            {
                string filePath = node.Name + ".txt";
                int criminalCount = 0;
                if (System.IO.File.Exists(filePath))
                {
                    try
                    {
                        string[] lines = System.IO.File.ReadAllLines(filePath);
                        foreach (string line in lines)
                        {
                            if (!string.IsNullOrWhiteSpace(line))
                                criminalCount++;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error reading file for: " + node.Name+" :"+ex.Message);
                    }
                }
                if (criminalCount >= 13)
                    node.AreaColor = Color.Maroon;         // High Danger
                else if (criminalCount >= 5)
                    node.AreaColor = Color.FromArgb(255, 128, 0);      // Medium Danger
                else
                    node.AreaColor = Color.FromArgb(0, 64, 0); // Safe
            }
            this.Invalidate();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.Show();
            this.Hide();
        }
    }
}
