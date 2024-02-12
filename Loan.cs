// This page will calculate the loan amount

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
    public partial class Loan : Form
    {
        // Declare static variable for summary form to access the values
        public static double monthly;
        public static string yearSelected;
        public static double totalInterest;

        // Display all the information about car model, variant, price and down payment price
        public void display()
        {
            double price = Home.price;
            String prices = Math.Round(price, 2).ToString("#.00"); // Format the result into two decimal places
            carLabel.Text = Home.car;
            varLabel.Text = Home.var;
            priceLabel.Text = prices;

            double downPrice = price / 10;
            String downPrices = Math.Round(downPrice, 2).ToString("#.00"); // Format the result into two decimal places
            downPaymentPriceLabel.Text = downPrices;
        }

        public Loan()
        {
            InitializeComponent();
        }

        private void Loan_Load(object sender, EventArgs e)
        {
            // Call the display method
            display();
        }

        // Calculate the monthly installment according to the selected loan period
        private void loanComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Declare all the values needed for loan calculation
            yearSelected = loanComboBox.SelectedItem.ToString();
            double price = Home.price;
            double downPrice = price / 10;
            double interest = 0.023;

            double netPrice = price - downPrice;

            // Calculate the montly installment for 7 year period
            if (yearSelected == "7 years")
            {
                totalInterest = netPrice * interest * 7;
                monthly = (totalInterest + netPrice) / (7 * 12);
                String montlyInstallment = Math.Round(monthly, 2).ToString("#.00"); // Format the result into two decimal places

                // Display the monthly installment
                installmentPriceLabel.Text = montlyInstallment;

                // Display the total interest
                String totalInt = Math.Round(totalInterest, 2).ToString("#.00"); // Format the result into two decimal places
                totalInterestPriceLabel.Text = totalInt;
            }
            // Calculate the montly installment for 9 year period
            else if (yearSelected == "9 years")
            {
                totalInterest = netPrice * interest * 9;
                monthly = (totalInterest + netPrice) / (9 * 12);
                String montlyInstallment = Math.Round(monthly, 2).ToString("#.00"); // Format the result into two decimal places

                // Display the monthly installment
                installmentPriceLabel.Text = montlyInstallment;

                // Display the total interest
                String totalInt = Math.Round(totalInterest, 2).ToString("#.00"); // Format the result into two decimal places
                totalInterestPriceLabel.Text = totalInt;
            }
        }

        // Navigate user back to home page
        private void backButton_Click(object sender, EventArgs e)
        {
            Home homePage = new Home();
            homePage.Show();
            this.Hide();
        }

        // Navigate user to summary page if the loan period combo box is not null
        private void nextButton_Click(object sender, EventArgs e)
        {
            if(loanComboBox.SelectedItem != null)
            {
                yearSelected = loanComboBox.SelectedItem.ToString();

                Summary summaryPage = new Summary();
                summaryPage.Show();
                this.Hide();
            }
            // If the loan combo box is not selected, a message box will pop up and show "Please choose a loan period."
            else
            {
                MessageBox.Show("Please choose a loan period.");
            }
        }
    }
}
