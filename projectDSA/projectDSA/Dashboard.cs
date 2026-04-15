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
    public partial class Dashboard : Form
    {
        List<Node> nodes = new List<Node>();
        List<Edge> edges = new List<Edge>();
        public Dashboard()
        {
            InitializeComponent();
            nodes = Graph.GetNodes();
            edges = Graph.GetEdges();
        }
        private void btnCrimeRecord_Click(object sender, EventArgs e)
        {
            CriminalRecord rec = new CriminalRecord();
            rec.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddCriminal add = new AddCriminal();
            add.Show();
            this.Hide();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
        private void btnSimulation_Click(object sender, EventArgs e)
        {
            int totalSimulations = 1000;
            Dictionary<string, int> counts = new Dictionary<string, int>();
            int totalCriminals = 0;
            // 1. Collect data
            foreach (var node in nodes)
            {
                int lines = 0;
                if (System.IO.File.Exists(node.Name + ".txt"))
                    lines = System.IO.File.ReadAllLines(node.Name + ".txt").Length;
                counts[node.Name] = lines;
                totalCriminals += lines;
            }
            if (totalCriminals == 0)
            {
                MessageBox.Show("No crime data available to run simulation.");
                return;
            }
            // 2. Run Monte Carlo Math
            Dictionary<string, double> finalProbabilities = new Dictionary<string, double>();
            Random rand = new Random();
            int[] tally = new int[nodes.Count];
            for (int i = 0; i < totalSimulations; i++)
            {
                int pick = rand.Next(0, totalCriminals);
                int cumulative = 0;
                for (int j = 0; j < nodes.Count; j++)
                {
                    cumulative += counts[nodes[j].Name];
                    if (pick < cumulative) { tally[j]++; break; }
                }
            }
            for (int j = 0; j < nodes.Count; j++)
            { finalProbabilities[nodes[j].Name] = (tally[j] / (double)totalSimulations) * 100; }
            SimulationOutput sc = new SimulationOutput(finalProbabilities);
            sc.Show();
            this.Hide();
        }
        private void btnShortDistance_Click(object sender, EventArgs e)
        {
            RouteMap map = new RouteMap();
            map.Show();
            this.Hide();
        }
    }
}
