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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        // When user clicked on the register button
        private void registerButton_Click_1(object sender, EventArgs e)
        {
            // If one of the text boxes are empty, a message box will pop up showing input required.
            if (passwordTextBox.Text == "" || passwordConfirmTextBox.Text == "" ||
                usernameTextBox.Text == "" || emailTextBox.Text == "")
            {
                MessageBox.Show("All input are required.");
            }
            // If the confirm password is same with password then a message box showing successfully 
            // registered will show up and bring the user to login page
            else if (passwordTextBox.Text == passwordConfirmTextBox.Text)
            {
                MessageBox.Show("Successfully registered.");
                Login LoginPage = new Login();
                LoginPage.Show();
                this.Hide();
            }
        }

        // Validates the username text box to make sure it is not empty
        private void usernameTextBox_Validating_1(object sender, CancelEventArgs e)
        {
            // If username text box is empty, a message box will pop up showing username required.
            if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Username required.");
                usernameTextBox.Focus();
                return;
            }
        }

        // Validates the email text box to make sure it is not empty and entered with correct format
        private void emailTextBox_Validating(object sender, CancelEventArgs e)
        {
            // This 'try' will indicates whether the email is in the correct format or not
            try
            {
                new System.Net.Mail.MailAddress(this.emailTextBox.Text);
            }
            // If email text box is empty, a message box will pop up showing email required.
            catch (ArgumentException)
            {
                MessageBox.Show("Email required.");
            }
            // If the email format is wrong, a message box will pop up showing invalid format.
            catch (FormatException)
            {
                MessageBox.Show("Invalid email format.");
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

        // Validates the confirm password text box to make sure the content is same with password text box
        private void passwordConfirmTextBox_Validating(object sender, CancelEventArgs e)
        {
            // If confirm password is not the same with password, a message box will pop up showing password not match.
            if (passwordConfirmTextBox.Text != passwordTextBox.Text)
            {
                MessageBox.Show("Password not match.");
                passwordConfirmTextBox.Focus();
                return;
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
