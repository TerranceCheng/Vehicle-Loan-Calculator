using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _CIT2574__Assignment_1____Cheng_Yong_Tat___2021_10_28_
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // Validates the username text box to make sure it is not empty
        private void usernameTextBox_Validating(object sender, CancelEventArgs e)
        {
            // If username text box is empty, a message box will pop up showing username required.
            if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Username required.");
                usernameTextBox.Focus();
                return;
            }
        }

        // Validates the password text box to make sure it is not empty
        private void passwordTextBox_Validating(object sender, CancelEventArgs e)
        {
            // If password text box is empty, a message box will pop up showing password required.
            if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password required.");
                passwordTextBox.Focus();
                return;
            }
        }

        // Navigate user to Proton home page when all the requirements are reached
        private void loginButton_Click(object sender, EventArgs e)
        {
            // Navigate user to Proton home page when the username is "nadia" and password is "nadia0012"
            if (usernameTextBox.Text == "nadia" && passwordTextBox.Text == "nadia0012")
            {
                Home ProtonHomePage = new Home();
                ProtonHomePage.Show();
                this.Hide();
            }
            // If username text box is empty, a message box will pop up showing username required.
            else if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Username required.");
            }
            // If password text box is empty, a message box will pop up showing password required.
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password required.");
            }
            // If username is not the same with "nadia", a message box will pop up showing invalid username.
            else if (usernameTextBox.Text != "nadia")
            {
                MessageBox.Show("Invalid username.");
            }
            // If password is not the same with "nadia0012", a message box will pop up showing invalid password.
            else if (passwordTextBox.Text != "nadia0012")
            {
                MessageBox.Show("Invalid password.");
                passwordTextBox.Text = "";
            }
        }
    }
}
