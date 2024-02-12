// This is the summary page

﻿using System;
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
    public partial class Summary : Form
    {
        // Display all the information about car image, model, variant, price,
        // down payment price, loan period and monthly installment
        public void display()
        {
            // Assign all the variables with values from loan page
            double price = Home.price;
            String prices = Math.Round(price, 2).ToString("#.00"); // Format the result into two decimal places
            carLabel.Text = Home.car;
            varLabel.Text = Home.var;
            priceLabel.Text = prices;
            carPictureBox.Image = Home.carPic;

            // Calculate and display down payment price
            double downPrice = price / 10;
            String downPrices = Math.Round(downPrice, 2).ToString("#.00"); // Format the result into two decimal places
            downPaymentPriceLabel.Text = downPrices;

            // Calculate and display monthly installment
            double monthlyIns = Loan.monthly;
            String monthlyInstallment = Math.Round(monthlyIns, 2).ToString("#.00"); // Format the result into two decimal places
            installmentPriceLabel.Text = monthlyInstallment;

            // Display the selected loan period
            string yearSelect = Loan.yearSelected;
            periodLabel.Text = yearSelect;

            // Calculate and display total interest
            double totalInterest = Loan.totalInterest;
            String totalInt = Math.Round(totalInterest, 2).ToString("#.00"); // Format the result into two decimal places
            totalInterestPriceLabel.Text = totalInt;
        }

        public Summary()
        {
            InitializeComponent();
        }

        // Call the display method
        private void Summary_Load(object sender, EventArgs e)
        {
            display();
        }

        // Navigate the user back to loan page
        private void backButton_Click(object sender, EventArgs e)
        {
            Loan loanPage = new Loan();
            loanPage.Show();
            this.Hide();
        }

        // Show a successfully booked message and exit the application when user click the "Book" button
        private void bookButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully booked.");
            Application.Exit();
        }
    }
}
