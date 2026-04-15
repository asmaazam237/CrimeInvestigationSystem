using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace projectDSA
{
    public partial class SimulationOutput : Form
    {
        private Dictionary<string, double> _results;
        private int _progress = 0;
        public SimulationOutput(Dictionary<string, double> results)
        {
            InitializeComponent();
            _results = results;
            progressBar1.Value = 0;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            _progress += 5;
            if (_progress <= 100)
            {
                progressBar1.Value = _progress;
            }
            else
            {
                timer1.Stop();
                DisplayBarChart(); // Show the chart only when "loading" is done
            }
        }
        private void DisplayBarChart()
        {
            chart1.Series.Clear();
            var series = chart1.Series.Add("Crime Probability (%)");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            // 1. Force every label to show (Interval = 1)
            chart1.ChartAreas[0].AxisX.Interval = 1;
            // 2. Rotate labels so long names don't overlap
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // You can use -90 for vertical
            // 3. Optional: Ensure the font is small enough to fit everyone
            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 8);
            foreach (var item in _results)
            {
                series.Points.AddXY(item.Key, item.Value);
            }
            MessageBox.Show("Simulation is completed!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.Show();
            this.Hide();
        }
    }
}
