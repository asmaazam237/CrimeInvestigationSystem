using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectDSA
{
    public partial class AddCriminal : Form
    {
        public AddCriminal()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAge.Text == "" || txtCrime.Text == "" || txtName.Text == "")
            {
                MessageBox.Show("The information is missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string filePath = $"{cbSelectArea.Text}.txt";
            if (File.Exists(filePath))
            {
                try
                {
                    int sno = 1; // Default serial number
                    if (File.Exists(filePath))
                    {
                        // Read all lines from the file
                        string[] lines = File.ReadAllLines(filePath);
                        if (lines.Length > 0)
                        {
                            // Get the last line
                            string lastLine = lines[lines.Length - 1];
                            string[] parts = lastLine.Split(',');
                            // Extract and increment the serial number
                            sno = int.Parse(parts[0]) + 1;
                        }
                    }
                    // --- DATE TIME PICKER LOGIC ---
                    string formattedDate = dtpCrimeDateTime.Value.ToString("dd-MM-yyyy"); // 02-03-2025
                    string formattedTime = dtpCrimeDateTime.Value.ToString("HH:mm");      // 17:45 (24hr format)
                    string formattedDay = dtpCrimeDateTime.Value.DayOfWeek.ToString();   // Sunday
                    // Write the new record to the file
                    using (StreamWriter sw = new StreamWriter(filePath, true))
                    {
                        sw.WriteLine($"{sno},{txtName.Text.Trim()},{txtCrime.Text.Trim()},{txtAge.Text.Trim()},{formattedDate},{formattedTime},{formattedDay}");
                    }
                    MessageBox.Show("Criminal record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Clear the textboxes for the next entry
                    txtName.Clear();
                    txtCrime.Clear();
                    txtAge.Clear();
                    dtpCrimeDateTime.Value = DateTime.Now;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}\n{ex.Message}", "Error");
                }
            }
            else
            {
                txtName.Clear();
                txtCrime.Clear();
                txtAge.Clear();
            }
        }
    }
}
