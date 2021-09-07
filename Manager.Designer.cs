
namespace RestaurantManagement
{
    partial class Manager
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnGridPur = new System.Windows.Forms.Button();
            this.btnAddUtility = new System.Windows.Forms.Button();
            this.lblUtility = new System.Windows.Forms.Label();
            this.btnGridPurchase = new System.Windows.Forms.Button();
            this.btnAddRawMat = new System.Windows.Forms.Button();
            this.lblPurchase = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblItem = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.pnlPrime = new System.Windows.Forms.Panel();
            this.pnlGridPrime = new System.Windows.Forms.Panel();
            this.btnBilling = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(46, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGER";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.btnGridPur);
            this.pnlMenu.Controls.Add(this.btnAddUtility);
            this.pnlMenu.Controls.Add(this.lblUtility);
            this.pnlMenu.Controls.Add(this.btnGridPurchase);
            this.pnlMenu.Controls.Add(this.btnAddRawMat);
            this.pnlMenu.Controls.Add(this.lblPurchase);
            this.pnlMenu.Controls.Add(this.btnShow);
            this.pnlMenu.Controls.Add(this.lblItem);
            this.pnlMenu.Controls.Add(this.btnAddItem);
            this.pnlMenu.Location = new System.Drawing.Point(-1, 38);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(224, 516);
            this.pnlMenu.TabIndex = 2;
            // 
            // btnGridPur
            // 
            this.btnGridPur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGridPur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGridPur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGridPur.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGridPur.Location = new System.Drawing.Point(35, 450);
            this.btnGridPur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGridPur.Name = "btnGridPur";
            this.btnGridPur.Size = new System.Drawing.Size(168, 62);
            this.btnGridPur.TabIndex = 12;
            this.btnGridPur.Text = "GRIDVIEW UTILITY";
            this.btnGridPur.UseVisualStyleBackColor = false;
            this.btnGridPur.Click += new System.EventHandler(this.btnGridPur_Click);
            // 
            // btnAddUtility
            // 
            this.btnAddUtility.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddUtility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUtility.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddUtility.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddUtility.Location = new System.Drawing.Point(35, 382);
            this.btnAddUtility.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddUtility.Name = "btnAddUtility";
            this.btnAddUtility.Size = new System.Drawing.Size(168, 64);
            this.btnAddUtility.TabIndex = 11;
            this.btnAddUtility.Text = "ADD UTILITY BILL";
            this.btnAddUtility.UseVisualStyleBackColor = false;
            this.btnAddUtility.Click += new System.EventHandler(this.btnAddUtility_Click);
            // 
            // lblUtility
            // 
            this.lblUtility.AutoSize = true;
            this.lblUtility.BackColor = System.Drawing.Color.Transparent;
            this.lblUtility.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtility.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblUtility.Location = new System.Drawing.Point(69, 353);
            this.lblUtility.Name = "lblUtility";
            this.lblUtility.Size = new System.Drawing.Size(93, 25);
            this.lblUtility.TabIndex = 10;
            this.lblUtility.Text = "UTILITY";
            // 
            // btnGridPurchase
            // 
            this.btnGridPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGridPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGridPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGridPurchase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGridPurchase.Location = new System.Drawing.Point(35, 265);
            this.btnGridPurchase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGridPurchase.Name = "btnGridPurchase";
            this.btnGridPurchase.Size = new System.Drawing.Size(168, 70);
            this.btnGridPurchase.TabIndex = 9;
            this.btnGridPurchase.Text = "GRIDVIEW PURCHASE";
            this.btnGridPurchase.UseVisualStyleBackColor = false;
            this.btnGridPurchase.Click += new System.EventHandler(this.btnGridPurchase_Click);
            // 
            // btnAddRawMat
            // 
            this.btnAddRawMat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddRawMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRawMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddRawMat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddRawMat.Location = new System.Drawing.Point(35, 194);
            this.btnAddRawMat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRawMat.Name = "btnAddRawMat";
            this.btnAddRawMat.Size = new System.Drawing.Size(168, 65);
            this.btnAddRawMat.TabIndex = 8;
            this.btnAddRawMat.Text = "ADD RAW MATERIALS";
            this.btnAddRawMat.UseVisualStyleBackColor = false;
            this.btnAddRawMat.Click += new System.EventHandler(this.btnAddRawMat_Click);
            // 
            // lblPurchase
            // 
            this.lblPurchase.AutoSize = true;
            this.lblPurchase.BackColor = System.Drawing.Color.Transparent;
            this.lblPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPurchase.Location = new System.Drawing.Point(44, 167);
            this.lblPurchase.Name = "lblPurchase";
            this.lblPurchase.Size = new System.Drawing.Size(130, 25);
            this.lblPurchase.TabIndex = 7;
            this.lblPurchase.Text = "PURCHASE";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShow.Location = new System.Drawing.Point(36, 82);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(165, 63);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "GRIDVIEW ITEM";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.BackColor = System.Drawing.Color.Transparent;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblItem.Location = new System.Drawing.Point(83, 12);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(64, 25);
            this.lblItem.TabIndex = 3;
            this.lblItem.Text = "ITEM";
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddItem.Location = new System.Drawing.Point(36, 39);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(165, 38);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "ADD ITEM";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // pnlPrime
            // 
            this.pnlPrime.BackColor = System.Drawing.Color.Transparent;
            this.pnlPrime.Location = new System.Drawing.Point(229, 62);
            this.pnlPrime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPrime.Name = "pnlPrime";
            this.pnlPrime.Size = new System.Drawing.Size(454, 559);
            this.pnlPrime.TabIndex = 3;
            // 
            // pnlGridPrime
            // 
            this.pnlGridPrime.BackColor = System.Drawing.Color.Transparent;
            this.pnlGridPrime.Location = new System.Drawing.Point(689, 62);
            this.pnlGridPrime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGridPrime.Name = "pnlGridPrime";
            this.pnlGridPrime.Size = new System.Drawing.Size(647, 559);
            this.pnlGridPrime.TabIndex = 4;
            // 
            // btnBilling
            // 
            this.btnBilling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBilling.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBilling.Location = new System.Drawing.Point(35, 2);
            this.btnBilling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(168, 55);
            this.btnBilling.TabIndex = 13;
            this.btnBilling.Text = "BILLING";
            this.btnBilling.UseVisualStyleBackColor = false;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBilling);
            this.panel1.Location = new System.Drawing.Point(-1, 558);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 62);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Location = new System.Drawing.Point(1187, 11);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(149, 38);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.BackgroundImage = global::RestaurantManagement.Properties.Resources.pizza_2000602_1920;
            this.ClientSize = new System.Drawing.Size(1348, 634);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlGridPrime);
            this.Controls.Add(this.pnlPrime);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Manager";
            this.Text = "Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Manager_FormClosed);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Button btnAddItem;
        public System.Windows.Forms.Panel pnlPrime;
        public System.Windows.Forms.Panel pnlGridPrime;
        private System.Windows.Forms.Button btnGridPurchase;
        private System.Windows.Forms.Button btnAddRawMat;
        private System.Windows.Forms.Label lblPurchase;
        private System.Windows.Forms.Button btnGridPur;
        private System.Windows.Forms.Button btnAddUtility;
        private System.Windows.Forms.Label lblUtility;
        public System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
    }
}