using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace projectDSA
{
    public partial class CriminalRecord : Form
    {
        public CriminalRecord()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
        private void CriminalRecord_Load(object sender, EventArgs e)
        {     }

        private void cbSelectArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fileName = $"{cbSelectArea.Text}.txt";
            if (File.Exists(fileName))
            {
                lstViewRec.Items.Clear(); // Clear previous items
                try
                {
                    string[] lines = File.ReadAllLines(fileName);
                    if (lines.Length == 0)
                    {
                        MessageBox.Show("No record found for this area.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');

                        if (parts.Length >= 7)
                        {
                            // Format the record for display
                            string name = $"{parts[0]}. Name of Criminal: {parts[1]}";  // name
                            string crime = $"   Crime: {parts[2]}";      // crime
                            string age = $"   Age: {parts[3]}";             //age
                            string date = $"   Date of Crime: {parts[4]}";      // date
                            string time = $"   Time: {parts[5]}";  // time
                            string day = $"   Day: {parts[6]}";              //day
                            lstViewRec.Items.Add($"{name}");
                            lstViewRec.Items.Add($"{crime}");
                            lstViewRec.Items.Add($"{age}");
                            lstViewRec.Items.Add($"{date}");
                            lstViewRec.Items.Add($"{time}");
                            lstViewRec.Items.Add($"{day}");
                            lstViewRec.Items.Add(""); // Add a blank line for spacing
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading record: {ex.Message}", "Error");
                }
            }
            else
            {
                MessageBox.Show("File does not exist or no record available.", "Error");
            }
        }
    }
}
