namespace RestaurantManagement
{
    partial class Profit_Details
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profit_Details));
            this.lblProfit = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.btnShowSales = new System.Windows.Forms.Button();
            this.txtPurchase = new System.Windows.Forms.TextBox();
            this.lblSale = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUtility = new System.Windows.Forms.Label();
            this.txtUtility = new System.Windows.Forms.TextBox();
            this.lblSal = new System.Windows.Forms.Label();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.lblProLoss = new System.Windows.Forms.Label();
            this.txtProLoss = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.BackColor = System.Drawing.Color.Transparent;
            this.lblProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblProfit.Location = new System.Drawing.Point(192, 33);
            this.lblProfit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(415, 39);
            this.lblProfit.TabIndex = 15;
            this.lblProfit.Text = "PROFIT/LOSS DETAILS";
            // 
            // cmbMonth
            // 
            this.cmbMonth.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbMonth.Location = new System.Drawing.Point(272, 128);
            this.cmbMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 33);
            this.cmbMonth.TabIndex = 17;
            this.cmbMonth.Text = "month";
            // 
            // cmbYear
            // 
            this.cmbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2020",
            "2021"});
            this.cmbYear.Location = new System.Drawing.Point(419, 128);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 33);
            this.cmbYear.TabIndex = 18;
            this.cmbYear.Text = "year";
            // 
            // txtSales
            // 
            this.txtSales.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtSales.Location = new System.Drawing.Point(403, 263);
            this.txtSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSales.Name = "txtSales";
            this.txtSales.ReadOnly = true;
            this.txtSales.Size = new System.Drawing.Size(219, 30);
            this.txtSales.TabIndex = 19;
            // 
            // btnShowSales
            // 
            this.btnShowSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnShowSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowSales.Location = new System.Drawing.Point(272, 184);
            this.btnShowSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowSales.Name = "btnShowSales";
            this.btnShowSales.Size = new System.Drawing.Size(269, 48);
            this.btnShowSales.TabIndex = 20;
            this.btnShowSales.Text = "SHOW DETAILS";
            this.btnShowSales.UseVisualStyleBackColor = false;
            this.btnShowSales.Click += new System.EventHandler(this.btnShowSales_Click);
            // 
            // txtPurchase
            // 
            this.txtPurchase.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPurchase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPurchase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtPurchase.Location = new System.Drawing.Point(403, 310);
            this.txtPurchase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPurchase.Name = "txtPurchase";
            this.txtPurchase.ReadOnly = true;
            this.txtPurchase.Size = new System.Drawing.Size(219, 30);
            this.txtPurchase.TabIndex = 21;
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.BackColor = System.Drawing.Color.Transparent;
            this.lblSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSale.Location = new System.Drawing.Point(194, 264);
            this.lblSale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(199, 29);
            this.lblSale.TabIndex = 22;
            this.lblSale.Text = "TOTAL SALES :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(119, 311);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "TOTAL PURCHASES :";
            // 
            // lblUtility
            // 
            this.lblUtility.AutoSize = true;
            this.lblUtility.BackColor = System.Drawing.Color.Transparent;
            this.lblUtility.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtility.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblUtility.Location = new System.Drawing.Point(177, 359);
            this.lblUtility.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUtility.Name = "lblUtility";
            this.lblUtility.Size = new System.Drawing.Size(215, 29);
            this.lblUtility.TabIndex = 24;
            this.lblUtility.Text = "TOTAL UTILITY :";
            // 
            // txtUtility
            // 
            this.txtUtility.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUtility.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUtility.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUtility.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtUtility.Location = new System.Drawing.Point(403, 358);
            this.txtUtility.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUtility.Name = "txtUtility";
            this.txtUtility.ReadOnly = true;
            this.txtUtility.Size = new System.Drawing.Size(219, 30);
            this.txtUtility.TabIndex = 25;
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.BackColor = System.Drawing.Color.Transparent;
            this.lblSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSal.Location = new System.Drawing.Point(177, 408);
            this.lblSal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(216, 29);
            this.lblSal.TabIndex = 26;
            this.lblSal.Text = "TOTAL SALARY :";
            // 
            // txtSal
            // 
            this.txtSal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtSal.Location = new System.Drawing.Point(403, 407);
            this.txtSal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSal.Name = "txtSal";
            this.txtSal.ReadOnly = true;
            this.txtSal.Size = new System.Drawing.Size(219, 30);
            this.txtSal.TabIndex = 27;
            // 
            // lblProLoss
            // 
            this.lblProLoss.AutoSize = true;
            this.lblProLoss.BackColor = System.Drawing.Color.Transparent;
            this.lblProLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProLoss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblProLoss.Location = new System.Drawing.Point(190, 461);
            this.lblProLoss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProLoss.Name = "lblProLoss";
            this.lblProLoss.Size = new System.Drawing.Size(198, 29);
            this.lblProLoss.TabIndex = 28;
            this.lblProLoss.Text = "PROFIT/LOSS :";
            // 
            // txtProLoss
            // 
            this.txtProLoss.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtProLoss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtProLoss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtProLoss.Location = new System.Drawing.Point(403, 460);
            this.txtProLoss.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProLoss.Name = "txtProLoss";
            this.txtProLoss.ReadOnly = true;
            this.txtProLoss.Size = new System.Drawing.Size(219, 30);
            this.txtProLoss.TabIndex = 29;
            // 
            // Profit_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.txtProLoss);
            this.Controls.Add(this.lblProLoss);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.txtUtility);
            this.Controls.Add(this.lblUtility);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSale);
            this.Controls.Add(this.txtPurchase);
            this.Controls.Add(this.btnShowSales);
            this.Controls.Add(this.txtSales);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.lblProfit);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Profit_Details";
            this.Size = new System.Drawing.Size(842, 551);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.TextBox txtSales;
        private System.Windows.Forms.Button btnShowSales;
        private System.Windows.Forms.TextBox txtPurchase;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUtility;
        private System.Windows.Forms.TextBox txtUtility;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.Label lblProLoss;
        private System.Windows.Forms.TextBox txtProLoss;
    }
}
