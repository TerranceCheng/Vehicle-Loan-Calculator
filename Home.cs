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
    public partial class Home : Form
    {
        // Declare static variables for other forms to access to the value
        public static double price = 0;
        public static String car = "";
        public static String var = "";
        public static Image carPic;

        public Home()
        {
            InitializeComponent();
        }

        // To make the correct car combo box visible while making sure the variant combo box 
        // and colors are not visible to prevent errors
        private void carChoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = carChoiceComboBox.SelectedItem.ToString();

            // Make the correct image visible when the user choose a car model  
            if (selected == "Proton X50")
            {
                carPictureBox.Image = Properties.Resources.X50_white;
                X50VarianceComboBox.Visible = true;
                X70VarianceComboBox.Visible = false;
                personaVarianceComboBox.Visible = false;
                whiteButton.Visible = false;
                silverButton.Visible = false;
                greyButton.Visible = false;
                blueButton.Visible = false;
                orangeButton.Visible = false;
                redButton.Visible = false;
                darkGreyButton.Visible = false;
                brownButton.Visible = false;
            }
            else if (selected == "Proton X70")
            {
                carPictureBox.Image = Properties.Resources.X70_white;
                X50VarianceComboBox.Visible = false;
                X70VarianceComboBox.Visible = true;
                personaVarianceComboBox.Visible = false;
                whiteButton.Visible = false;
                silverButton.Visible = false;
                greyButton.Visible = false;
                blueButton.Visible = false;
                orangeButton.Visible = false;
                redButton.Visible = false;
                darkGreyButton.Visible = false;
                brownButton.Visible = false;
            }
            else if (selected == "Proton Persona")
            {
                carPictureBox.Image = Properties.Resources.persona_white;
                X50VarianceComboBox.Visible = false;
                X70VarianceComboBox.Visible = false;
                personaVarianceComboBox.Visible = true;
                whiteButton.Visible = false;
                silverButton.Visible = false;
                greyButton.Visible = false;
                blueButton.Visible = false;
                orangeButton.Visible = false;
                redButton.Visible = false;
                darkGreyButton.Visible = false;
                brownButton.Visible = false;
            }
        }

        // Make changes to the visibility of color buttons and price label when the car variant changes
        private void X50VarianceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Declare variable to store the selected items from car combo box and variant combo box
            string carSelected = carChoiceComboBox.SelectedItem.ToString();
            string varSelected = X50VarianceComboBox.SelectedItem.ToString();

            if (carSelected == "Proton X50")
            {
                carSpecLabel.Text = carSelected + " - " + varSelected;

                if (varSelected == "1.5T Standard")
                {
                    whiteButton.Visible = true;
                    silverButton.Visible = true;
                    greyButton.Visible = true;
                    blueButton.Visible = false;
                    orangeButton.Visible = false;
                    redButton.Visible = false;
                    priceLabel.Text = "79,200.00"; // Price for standard X50 variant
                }
                else if (varSelected == "1.5T Executive")
                {
                    whiteButton.Visible = true;
                    silverButton.Visible = true;
                    greyButton.Visible = true;
                    blueButton.Visible = true;
                    orangeButton.Visible = true;
                    redButton.Visible = false;
                    priceLabel.Text = "84,800.00"; // Price for executive X50 variant
                }
                else if (varSelected == "1.5T Premium")
                {
                    whiteButton.Visible = true;
                    silverButton.Visible = true;
                    greyButton.Visible = true;
                    blueButton.Visible = true;
                    orangeButton.Visible = true;
                    redButton.Visible = true;
                    priceLabel.Text = "93,200.00"; // Price for premium X50 variant
                }
                else if (varSelected == "1.5T TGDI Flagship")
                {
                    whiteButton.Visible = true;
                    silverButton.Visible = true;
                    greyButton.Visible = true;
                    blueButton.Visible = true;
                    orangeButton.Visible = true;
                    redButton.Visible = true;
                    priceLabel.Text = "103,300.00"; // Price for flagship X50 variant
                }
            }
        }

        // Make changes to the visibility of color buttons and price label when the car variant changes
        private void X70VarianceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Declare variable to store the selected items from car combo box and variant combo box
            string carSelected = carChoiceComboBox.SelectedItem.ToString();
            string varSelected = X70VarianceComboBox.SelectedItem.ToString();

            if (carSelected == "Proton X70")
            {
                carSpecLabel.Text = carSelected + " - " + varSelected;

                darkGreyButton.Visible = true;
                brownButton.Visible = true;
                greyButton.Visible = false;
                orangeButton.Visible = false;
                blueButton.Visible = false;

                if (varSelected == "1.8 TGWI Standard")
                {
                    whiteButton.Visible = true;
                    silverButton.Visible = true;
                    darkGreyButton.Visible = true;
                    greyButton.Visible = false;
                    brownButton.Visible = false;
                    redButton.Visible = false;
                    priceLabel.Text = "94,800.00"; // Price for standard X50 variant
                }
                else if (varSelected == "1.8 TGWI Executive")
                {
                    whiteButton.Visible = true;
                    silverButton.Visible = true;
                    darkGreyButton.Visible = true;
                    greyButton.Visible = false;
                    brownButton.Visible = true;
                    redButton.Visible = true;
                    priceLabel.Text = "106,800.00"; // Price for executive X70 variant
                }
                else if (varSelected == "1.8 TGWI Premium")
                {
                    whiteButton.Visible = true;
                    silverButton.Visible = true;
                    darkGreyButton.Visible = true;
                    greyButton.Visible = true;
                    brownButton.Visible = true;
                    redButton.Visible = true;
                    priceLabel.Text = "119,800.00"; // Price for premium X70 variant
                }
                else if (varSelected == "1.8 TGWI Premium X")
                {
                    whiteButton.Visible = true;
                    silverButton.Visible = true;
                    darkGreyButton.Visible = true;
                    greyButton.Visible = true;
                    brownButton.Visible = true;
                    redButton.Visible = true;
                    priceLabel.Text = "122,800.00"; // Price for premium X X70 variant
                }
                else if (varSelected == "Special Edition")
                {
                    whiteButton.Visible = true;
                    silverButton.Visible = true;
                    darkGreyButton.Visible = true;
                    greyButton.Visible = true;
                    brownButton.Visible = true;
                    redButton.Visible = true;
                    priceLabel.Text = "123,800.00"; // Price for special X70 variant
                }
            }
        }

        // Make changes to the visibility of color buttons and price label when the car variant changes
        private void personaVarianceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Declare variable to store the selected items from car combo box and variant combo box
            string carSelected = carChoiceComboBox.SelectedItem.ToString();
            string varSelected = personaVarianceComboBox.SelectedItem.ToString();

            if (carSelected == "Proton Persona")
            {
                carSpecLabel.Text = carSelected + " - " + varSelected;

                if (varSelected == "1.6L Standard CVT")
                {
                    whiteButton.Visible = false;
                    silverButton.Visible = true;
                    greyButton.Visible = true;
                    brownButton.Visible = true;
                    blueButton.Visible = false;
                    orangeButton.Visible = false;
                    redButton.Visible = true;
                    priceLabel.Text = "45,800.00"; // Price for standard persona variant
                }
                else if (varSelected == "1.6L Executive CVT")
                {
                    whiteButton.Visible = true;
                    silverButton.Visible = true;
                    greyButton.Visible = true;
                    brownButton.Visible = true;
                    blueButton.Visible = false;
                    orangeButton.Visible = false;
                    redButton.Visible = true;
                    priceLabel.Text = "50,800.00"; // Price for executive persona variant
                }
                else if (varSelected == "1.6L Premium CVT")
                {
                    whiteButton.Visible = true;
                    silverButton.Visible = true;
                    greyButton.Visible = true;
                    brownButton.Visible = true;
                    blueButton.Visible = false;
                    orangeButton.Visible = false;
                    redButton.Visible = true;
                    priceLabel.Text = "55,800.00"; // Price for premium persona variant
                }
            }
        }

        // Change the car image color and car description laabel according to the chosen car model, variant and color
        // White color
        private void whiteButton_Click(object sender, EventArgs e)
        {
            // Declare variable to store the selected items from car combo box
            string carSelected = carChoiceComboBox.SelectedItem.ToString();

            if (carSelected == "Proton X50")
            {
                carPictureBox.Image = Properties.Resources.X50_white;
                string varSelected = X50VarianceComboBox.SelectedItem.ToString();
                carSpecLabel.Text = carSelected + " - " + varSelected + " (White)";
            }
            else if (carSelected == "Proton X70")
            {
                carPictureBox.Image = Properties.Resources.X70_white;
                string varSelected = X70VarianceComboBox.SelectedItem.ToString();
                carSpecLabel.Text = carSelected + " - " + varSelected + " (White)";
            }
            else if (carSelected == "Proton Persona")
            {
                carPictureBox.Image = Properties.Resources.persona_white;
                string varSelected = personaVarianceComboBox.SelectedItem.ToString();
                carSpecLabel.Text = carSelected + " - " + varSelected + " (White)";
            }
        }

        // Change the car image color and car description laabel according to the chosen car model, variant and color
        // Silver color
        private void silverButton_Click(object sender, EventArgs e)
        {
            // Declare variable to store the selected items from car combo box
            string carSelected = carChoiceComboBox.SelectedItem.ToString();

            if (carSelected == "Proton X50")
            {
                carPictureBox.Image = Properties.Resources.X50_silver;
                string varSelected = X50VarianceComboBox.SelectedItem.ToString();
                carSpecLabel.Text = carSelected + " - " + varSelected + " (Silver)";
            }
            else if (carSelected == "Proton X70")
            {
                carPictureBox.Image = Properties.Resources.X70_silver;
                string varSelected = X70VarianceComboBox.SelectedItem.ToString();
                carSpecLabel.Text = carSelected + " - " + varSelected + " (Silver)";
            }
            else if (carSelected == "Proton Persona")
            {
                carPictureBox.Image = Properties.Resources.persona_silver;
                string varSelected = personaVarianceComboBox.SelectedItem.ToString();
                carSpecLabel.Text = carSelected + " - " + varSelected + " (Silver)";
            }
        }

        // Change the car image color and car description laabel according to the chosen car model, variant and color
        // Grey color
        private void greyButton_Click(object sender, EventArgs e)
        {
            // Declare variable to store the selected items from car combo box
            string carSelected = carChoiceComboBox.SelectedItem.ToString();

            if (carSelected == "Proton X50")
            {
                carPictureBox.Image = Properties.Resources.X50_grey;
                string varSelected = X50VarianceComboBox.SelectedItem.ToString();
                carSpecLabel.Text = carSelected + " - " + varSelected + " (Grey)";
            }
            else if (carSelected == "Proton X70")
            {
                carPictureBox.Image = Properties.Resources.X70_grey;
                string varSelected = X70VarianceComboBox.SelectedItem.ToString();
                carSpecLabel.Text = carSelected + " - " + varSelected + " (Grey)";
            }
            else if (carSelected == "Proton Persona")
            {
                carPictureBox.Image = Properties.Resources.persona_grey;
                string varSelected = personaVarianceComboBox.SelectedItem.ToString();
                carSpecLabel.Text = carSelected + " - " + varSelected + " (Grey)";
            }
        }

        // Change the car image color and car description laabel according to the chosen car model, variant and color
        // Blue color
        private void blueButton_Click(object sender, EventArgs e)
        {
            // Declare variable to store the selected items from car combo box
            string carSelected = carChoiceComboBox.SelectedItem.ToString();

            if (carSelected == "Proton X50")
            {
                carPictureBox.Image = Properties.Resources.X50_blue;
                string varSelected = X50VarianceComboBox.SelectedItem.ToString();
                carSpecLabel.Text = carSelected + " - " + varSelected + " (Blue)";
            }
        }

        // Change the car image color and car description laabel according to the chosen car model, variant and color
        // Orange color
        private void orangeButton_Click(object sender, EventArgs e)
        {
            // Declare variable to store the selected items from car combo box
            string carSelected = carChoiceComboBox.SelectedItem.ToString();

            if (carSelected == "Proton X50")
            {
                carPictureBox.Image = Properties.Resources.X50_orange;
                string varSelected = X50VarianceComboBox.SelectedItem.ToString();
                carSpecLabel.Text = carSelected + " - " + varSelected + " (Orange)";
            }
        }

        // Change the car image color and car description laabel according to the chosen car model, variant and color
        // Red color
        private void redButton_Click(object sender, EventArgs e)
        {
            // Declare variable to store the selected items from car combo box
            string carSelected = carChoiceComboBox.SelectedItem.ToString();

            if (carSelected == "Proton X50")
            {
                carPictureBox.Image = Properties.Resources.X50_red;
                string varSelected = X50VarianceComboBox.SelectedItem.ToString();
                carSpecLabel.Text = carSelected + " - " + varSelected + " (Red)";
            }
            else if (carSelected == "Proton X70")
            {
                carPictureBox.Image = Properties.Resources.X70_red;
                string varSelected = X70VarianceComboBox.SelectedItem.ToString();
                carSpecLabel.Text = carSelected + " - " + varSelected + " (Red)";
            }
            else if (carSelected == "Proton Persona")
            {
                carPictureBox.Image = Properties.Resources.persona_red;
                string varSelected = personaVarianceComboBox.SelectedItem.ToString();
                carSpecLabel.Text = carSelected + " - " + varSelected + " (Red)";
            }
        }

        // Change the car image color and car description laabel according to the chosen car model, variant and color
        // Dark grey color
        private void darkGreyButton_Click(object sender, EventArgs e)
        {
            // Declare variable to store the selected items from car combo box
            string carSelected = carChoiceComboBox.SelectedItem.ToString();

            if (carSelected == "Proton X70")
            {
                carPictureBox.Image = Properties.Resources.X70_darkGrey;
                string varSelected = X70VarianceComboBox.SelectedItem.ToString();
                carSpecLabel.Text = carSelected + " - " + varSelected + " (Dark Grey)";
            }
        }

        // Change the car image color and car description laabel according to the chosen car model, variant and color
        // Brown color
        private void brownButton_Click(object sender, EventArgs e)
        {
            // Declare variable to store the selected items from car combo box
            string carSelected = carChoiceComboBox.SelectedItem.ToString();

            if (carSelected == "Proton X70")
            {
                carPictureBox.Image = Properties.Resources.X70_brown;
                string varSelected = X70VarianceComboBox.SelectedItem.ToString();
                carSpecLabel.Text = carSelected + " - " + varSelected + " (Brown)";
            }
            else if (carSelected == "Proton Persona")
            {
                carPictureBox.Image = Properties.Resources.persona_brown;
                string varSelected = personaVarianceComboBox.SelectedItem.ToString();
                carSpecLabel.Text = carSelected + " - " + varSelected + " (Brown)";
            }
        }

        // Navigate user to loan page when all the combo boxed are selected and not null
        private void nextButton_Click(object sender, EventArgs e)
        {
            // If the car combo box is not null, it will navigate user to loan page while assign 
            // values to static variables for loan page to access its value
            if (carChoiceComboBox.SelectedItem != null)
            {
                string carSelected = carChoiceComboBox.SelectedItem.ToString();

                if (carSelected == "Proton X50")
                {
                    // Assign values to static variables
                    carPic = carPictureBox.Image;
                    car = carSelected;
                    price = Convert.ToDouble(priceLabel.Text);

                    if(X50VarianceComboBox.SelectedItem != null)
                    {
                        string varSelected = X50VarianceComboBox.SelectedItem.ToString();
                        var = varSelected;
                        Loan loanPage = new Loan();
                        loanPage.Show();
                        this.Hide();
                    }
                    // A message box will show up if the variant combo box is not selected with any choices
                    else
                    {
                        MessageBox.Show("Please choose a car model and variant.");
                    }
                }
                else if (carSelected == "Proton X70")
                {
                    // Assign values to static variables
                    carPic = carPictureBox.Image;
                    car = carSelected;
                    price = Convert.ToDouble(priceLabel.Text);

                    if (X70VarianceComboBox.SelectedItem != null)
                    {
                        string varSelected = X70VarianceComboBox.SelectedItem.ToString();
                        var = varSelected;
                        Loan loanPage = new Loan();
                        loanPage.Show();
                        this.Hide();
                    }
                    // A message box will show up if the variant combo box is not selected with any choices
                    else
                    {
                        MessageBox.Show("Please choose a car model and variant.");
                    }
                }
                else if (carSelected == "Proton Persona")
                {
                    // Assign values to static variables
                    carPic = carPictureBox.Image;
                    car = carSelected;
                    price = Convert.ToDouble(priceLabel.Text);

                    if (personaVarianceComboBox.SelectedItem != null)
                    {
                        string varSelected = personaVarianceComboBox.SelectedItem.ToString();
                        var = varSelected;
                        Loan loanPage = new Loan();
                        loanPage.Show();
                        this.Hide();
                    }
                    // A message box will show up if the variant combo box is not selected with any choices
                    else
                    {
                        MessageBox.Show("Please choose a car model and variant.");
                    }
                }
            }
            // A message box will show up if the car combo box and variant combo box are not selected with any choices
            else
            {
                MessageBox.Show("Please choose a car model and variant.");
            }
        }
    }
}
