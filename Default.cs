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
    public partial class Default : Form
    {
        public Default()
        {
            InitializeComponent();
        }

        //Navigate user to register page to register their information
        private void registerButton_Click(object sender, EventArgs e)
        {
            Register RegisterPage = new Register();
            RegisterPage.Show();
            this.Hide();
        }

        //Navigate user to login page to login into the page
        private void loginButton_Click_1(object sender, EventArgs e)
        {
            Login LoginPage = new Login();
            LoginPage.Show();
            this.Hide();
        }
    }
}
