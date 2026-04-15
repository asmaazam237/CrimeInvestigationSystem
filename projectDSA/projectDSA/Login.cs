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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void loginbtn_Click(object sender, EventArgs e)
        {
            string[] adminUsernames = { "admin", "aliza", "asma", "alifya", "saniya" };
            string[] adminPasswords = { "admin021", "aliza021", "asma021", "alifya021","saniya021" };

            string inputUser = usertxt.Text.Trim();
            string inputPass = passtxt.Text.Trim();

            if (inputUser == "" || inputPass == "")
            {
                MessageBox.Show("Username or Password is missing.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isAuthenticated = false;

            // Loop through the arrays to find a match
            for (int i = 0; i < adminUsernames.Length; i++)
            {
                // Check if both username and password match at the same index
                if (inputUser == adminUsernames[i] && inputPass == adminPasswords[i])
                {
                    isAuthenticated = true;
                    break; // Exit loop once a match is found
                }
            }

            if (isAuthenticated)
            {
                MessageBox.Show("Login Successful!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usertxt.Text = "";
                passtxt.Text = "";
            }
        }
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (passtxt.UseSystemPasswordChar == true)
            {
                passtxt.UseSystemPasswordChar = false;
                passtxt.PasswordChar = '\0';
                btnShowPassword.Text = "Hide Password";
            }
            else
            {
                passtxt.UseSystemPasswordChar = true;
                btnShowPassword.Text = "Show Password";
            }
        }
    }
}
