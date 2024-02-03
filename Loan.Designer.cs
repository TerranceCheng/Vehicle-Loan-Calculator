
namespace _CIT2574__Assignment_1____Cheng_Yong_Tat___2021_10_28_
{
    partial class Loan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loan));
            this.loginLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.modelLabel = new System.Windows.Forms.Label();
            this.varianceLabel = new System.Windows.Forms.Label();
            this.carLabel = new System.Windows.Forms.Label();
            this.varLabel = new System.Windows.Forms.Label();
            this.rmLabel = new System.Windows.Forms.Label();
            this.priceTagLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.loanComboBox = new System.Windows.Forms.ComboBox();
            this.loanLabel = new System.Windows.Forms.Label();
            this.downPaymentLabel = new System.Windows.Forms.Label();
            this.downPaymentPriceLabel = new System.Windows.Forms.Label();
            this.rmLabel2 = new System.Windows.Forms.Label();
            this.installmentLabel = new System.Windows.Forms.Label();
            this.rmLabel3 = new System.Windows.Forms.Label();
            this.installmentPriceLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.interestLabel = new System.Windows.Forms.Label();
            this.interestLabelText = new System.Windows.Forms.Label();
            this.totalInterestPriceLabel = new System.Windows.Forms.Label();
            this.totalInterestLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginLabel.Location = new System.Drawing.Point(369, 57);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(306, 47);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Loan Calculator";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.loginLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 164);
            this.panel1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(770, 424);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(165, 42);
            this.nextButton.TabIndex = 24;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.Location = new System.Drawing.Point(117, 202);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(105, 23);
            this.modelLabel.TabIndex = 30;
            this.modelLabel.Text = "Car Model: ";
            // 
            // varianceLabel
            // 
            this.varianceLabel.AutoSize = true;
            this.varianceLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varianceLabel.Location = new System.Drawing.Point(117, 235);
            this.varianceLabel.Name = "varianceLabel";
            this.varianceLabel.Size = new System.Drawing.Size(78, 23);
            this.varianceLabel.TabIndex = 31;
            this.varianceLabel.Text = "Variant:";
            // 
            // carLabel
            // 
            this.carLabel.AutoSize = true;
            this.carLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carLabel.Location = new System.Drawing.Point(272, 202);
            this.carLabel.Name = "carLabel";
            this.carLabel.Size = new System.Drawing.Size(69, 23);
            this.carLabel.TabIndex = 32;
            this.carLabel.Text = "Proton";
            // 
            // varLabel
            // 
            this.varLabel.AutoSize = true;
            this.varLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varLabel.Location = new System.Drawing.Point(272, 235);
            this.varLabel.Name = "varLabel";
            this.varLabel.Size = new System.Drawing.Size(69, 23);
            this.varLabel.TabIndex = 33;
            this.varLabel.Text = "Proton";
            // 
            // rmLabel
            // 
            this.rmLabel.AutoSize = true;
            this.rmLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmLabel.Location = new System.Drawing.Point(272, 268);
            this.rmLabel.Name = "rmLabel";
            this.rmLabel.Size = new System.Drawing.Size(38, 23);
            this.rmLabel.TabIndex = 35;
            this.rmLabel.Text = "RM";
            // 
            // priceTagLabel
            // 
            this.priceTagLabel.AutoSize = true;
            this.priceTagLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTagLabel.Location = new System.Drawing.Point(117, 268);
            this.priceTagLabel.Name = "priceTagLabel";
            this.priceTagLabel.Size = new System.Drawing.Size(59, 23);
            this.priceTagLabel.TabIndex = 34;
            this.priceTagLabel.Text = "Price:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(313, 268);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(21, 23);
            this.priceLabel.TabIndex = 36;
            this.priceLabel.Text = "0";
            // 
            // loanComboBox
            // 
            this.loanComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanComboBox.FormattingEnabled = true;
            this.loanComboBox.ItemHeight = 25;
            this.loanComboBox.Items.AddRange(new object[] {
            "7 years",
            "9 years"});
            this.loanComboBox.Location = new System.Drawing.Point(599, 231);
            this.loanComboBox.Name = "loanComboBox";
            this.loanComboBox.Size = new System.Drawing.Size(274, 33);
            this.loanComboBox.TabIndex = 37;
            this.loanComboBox.SelectedIndexChanged += new System.EventHandler(this.loanComboBox_SelectedIndexChanged);
            // 
            // loanLabel
            // 
            this.loanLabel.AutoSize = true;
            this.loanLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanLabel.Location = new System.Drawing.Point(595, 202);
            this.loanLabel.Name = "loanLabel";
            this.loanLabel.Size = new System.Drawing.Size(119, 23);
            this.loanLabel.TabIndex = 38;
            this.loanLabel.Text = "Loan period:";
            // 
            // downPaymentLabel
            // 
            this.downPaymentLabel.AutoSize = true;
            this.downPaymentLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downPaymentLabel.Location = new System.Drawing.Point(117, 323);
            this.downPaymentLabel.Name = "downPaymentLabel";
            this.downPaymentLabel.Size = new System.Drawing.Size(145, 23);
            this.downPaymentLabel.TabIndex = 39;
            this.downPaymentLabel.Text = "Down Payment:";
            // 
            // downPaymentPriceLabel
            // 
            this.downPaymentPriceLabel.AutoSize = true;
            this.downPaymentPriceLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downPaymentPriceLabel.Location = new System.Drawing.Point(313, 323);
            this.downPaymentPriceLabel.Name = "downPaymentPriceLabel";
            this.downPaymentPriceLabel.Size = new System.Drawing.Size(21, 23);
            this.downPaymentPriceLabel.TabIndex = 41;
            this.downPaymentPriceLabel.Text = "0";
            // 
            // rmLabel2
            // 
            this.rmLabel2.AutoSize = true;
            this.rmLabel2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmLabel2.Location = new System.Drawing.Point(272, 323);
            this.rmLabel2.Name = "rmLabel2";
            this.rmLabel2.Size = new System.Drawing.Size(38, 23);
            this.rmLabel2.TabIndex = 40;
            this.rmLabel2.Text = "RM";
            // 
            // installmentLabel
            // 
            this.installmentLabel.AutoSize = true;
            this.installmentLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installmentLabel.Location = new System.Drawing.Point(595, 294);
            this.installmentLabel.Name = "installmentLabel";
            this.installmentLabel.Size = new System.Drawing.Size(188, 23);
            this.installmentLabel.TabIndex = 42;
            this.installmentLabel.Text = "Monthly Installment:";
            // 
            // rmLabel3
            // 
            this.rmLabel3.AutoSize = true;
            this.rmLabel3.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmLabel3.Location = new System.Drawing.Point(593, 332);
            this.rmLabel3.Name = "rmLabel3";
            this.rmLabel3.Size = new System.Drawing.Size(58, 36);
            this.rmLabel3.TabIndex = 43;
            this.rmLabel3.Text = "RM";
            // 
            // installmentPriceLabel
            // 
            this.installmentPriceLabel.AutoSize = true;
            this.installmentPriceLabel.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installmentPriceLabel.Location = new System.Drawing.Point(672, 332);
            this.installmentPriceLabel.Name = "installmentPriceLabel";
            this.installmentPriceLabel.Size = new System.Drawing.Size(32, 36);
            this.installmentPriceLabel.TabIndex = 44;
            this.installmentPriceLabel.Text = "0";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(599, 424);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(165, 42);
            this.backButton.TabIndex = 45;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // interestLabel
            // 
            this.interestLabel.AutoSize = true;
            this.interestLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestLabel.Location = new System.Drawing.Point(272, 355);
            this.interestLabel.Name = "interestLabel";
            this.interestLabel.Size = new System.Drawing.Size(54, 23);
            this.interestLabel.TabIndex = 67;
            this.interestLabel.Text = "2.3%";
            // 
            // interestLabelText
            // 
            this.interestLabelText.AutoSize = true;
            this.interestLabelText.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestLabelText.Location = new System.Drawing.Point(117, 355);
            this.interestLabelText.Name = "interestLabelText";
            this.interestLabelText.Size = new System.Drawing.Size(125, 23);
            this.interestLabelText.TabIndex = 66;
            this.interestLabelText.Text = "Interest (%) :";
            // 
            // totalInterestPriceLabel
            // 
            this.totalInterestPriceLabel.AutoSize = true;
            this.totalInterestPriceLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalInterestPriceLabel.Location = new System.Drawing.Point(313, 388);
            this.totalInterestPriceLabel.Name = "totalInterestPriceLabel";
            this.totalInterestPriceLabel.Size = new System.Drawing.Size(21, 23);
            this.totalInterestPriceLabel.TabIndex = 69;
            this.totalInterestPriceLabel.Text = "0";
            // 
            // totalInterestLabel
            // 
            this.totalInterestLabel.AutoSize = true;
            this.totalInterestLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalInterestLabel.Location = new System.Drawing.Point(117, 388);
            this.totalInterestLabel.Name = "totalInterestLabel";
            this.totalInterestLabel.Size = new System.Drawing.Size(130, 23);
            this.totalInterestLabel.TabIndex = 68;
            this.totalInterestLabel.Text = "Total Interest:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 23);
            this.label3.TabIndex = 70;
            this.label3.Text = "RM";
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(982, 503);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalInterestPriceLabel);
            this.Controls.Add(this.totalInterestLabel);
            this.Controls.Add(this.interestLabel);
            this.Controls.Add(this.interestLabelText);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.installmentPriceLabel);
            this.Controls.Add(this.rmLabel3);
            this.Controls.Add(this.installmentLabel);
            this.Controls.Add(this.downPaymentPriceLabel);
            this.Controls.Add(this.rmLabel2);
            this.Controls.Add(this.downPaymentLabel);
            this.Controls.Add(this.loanLabel);
            this.Controls.Add(this.loanComboBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.rmLabel);
            this.Controls.Add(this.priceTagLabel);
            this.Controls.Add(this.varLabel);
            this.Controls.Add(this.carLabel);
            this.Controls.Add(this.varianceLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nextButton);
            this.Name = "Loan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Loan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label varianceLabel;
        private System.Windows.Forms.Label carLabel;
        private System.Windows.Forms.Label varLabel;
        private System.Windows.Forms.Label rmLabel;
        private System.Windows.Forms.Label priceTagLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.ComboBox loanComboBox;
        private System.Windows.Forms.Label loanLabel;
        private System.Windows.Forms.Label downPaymentLabel;
        private System.Windows.Forms.Label downPaymentPriceLabel;
        private System.Windows.Forms.Label rmLabel2;
        private System.Windows.Forms.Label installmentLabel;
        private System.Windows.Forms.Label rmLabel3;
        private System.Windows.Forms.Label installmentPriceLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label interestLabel;
        private System.Windows.Forms.Label interestLabelText;
        private System.Windows.Forms.Label totalInterestPriceLabel;
        private System.Windows.Forms.Label totalInterestLabel;
        private System.Windows.Forms.Label label3;
    }
}