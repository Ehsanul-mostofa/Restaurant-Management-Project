
namespace RestaurantManagement
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlEmpUserControls = new System.Windows.Forms.Panel();
            this.pnlEmpButtons = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnProfit = new System.Windows.Forms.Button();
            this.btnAdminFormShow = new System.Windows.Forms.Button();
            this.btnAdminFormAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAdmin.SuspendLayout();
            this.pnlEmpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlAdmin.BackgroundImage = global::RestaurantManagement.Properties.Resources.pizza_2000602_1920;
            this.pnlAdmin.Controls.Add(this.label2);
            this.pnlAdmin.Controls.Add(this.label1);
            this.pnlAdmin.Controls.Add(this.pnlEmpUserControls);
            this.pnlAdmin.Controls.Add(this.pnlEmpButtons);
            this.pnlAdmin.Location = new System.Drawing.Point(-1, -2);
            this.pnlAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(1065, 666);
            this.pnlAdmin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1060, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = " TO EDIT, CLICK SHOW EMPLOYEE THEN DOUBLE CLICK ON GRIDVIEW                      " +
    "     ";
            // 
            // pnlEmpUserControls
            // 
            this.pnlEmpUserControls.BackColor = System.Drawing.Color.Transparent;
            this.pnlEmpUserControls.Location = new System.Drawing.Point(186, 83);
            this.pnlEmpUserControls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlEmpUserControls.Name = "pnlEmpUserControls";
            this.pnlEmpUserControls.Size = new System.Drawing.Size(862, 552);
            this.pnlEmpUserControls.TabIndex = 1;
            this.pnlEmpUserControls.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEmpUserControls_Paint);
            // 
            // pnlEmpButtons
            // 
            this.pnlEmpButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlEmpButtons.Controls.Add(this.button1);
            this.pnlEmpButtons.Controls.Add(this.btnProfit);
            this.pnlEmpButtons.Controls.Add(this.btnAdminFormShow);
            this.pnlEmpButtons.Controls.Add(this.btnAdminFormAdd);
            this.pnlEmpButtons.Location = new System.Drawing.Point(14, 79);
            this.pnlEmpButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlEmpButtons.Name = "pnlEmpButtons";
            this.pnlEmpButtons.Size = new System.Drawing.Size(148, 556);
            this.pnlEmpButtons.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 410);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProfit
            // 
            this.btnProfit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnProfit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnProfit.ForeColor = System.Drawing.Color.White;
            this.btnProfit.Location = new System.Drawing.Point(0, 298);
            this.btnProfit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProfit.Name = "btnProfit";
            this.btnProfit.Size = new System.Drawing.Size(148, 75);
            this.btnProfit.TabIndex = 2;
            this.btnProfit.Text = "PROFIT DETAILS";
            this.btnProfit.UseVisualStyleBackColor = false;
            this.btnProfit.Click += new System.EventHandler(this.btnProfit_Click);
            // 
            // btnAdminFormShow
            // 
            this.btnAdminFormShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdminFormShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminFormShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnAdminFormShow.ForeColor = System.Drawing.Color.White;
            this.btnAdminFormShow.Location = new System.Drawing.Point(0, 201);
            this.btnAdminFormShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdminFormShow.Name = "btnAdminFormShow";
            this.btnAdminFormShow.Size = new System.Drawing.Size(148, 69);
            this.btnAdminFormShow.TabIndex = 1;
            this.btnAdminFormShow.Text = "SHOW EMPLOYEE";
            this.btnAdminFormShow.UseVisualStyleBackColor = false;
            this.btnAdminFormShow.Click += new System.EventHandler(this.btnAdminFormShow_Click);
            // 
            // btnAdminFormAdd
            // 
            this.btnAdminFormAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdminFormAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminFormAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminFormAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdminFormAdd.Location = new System.Drawing.Point(0, 106);
            this.btnAdminFormAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdminFormAdd.Name = "btnAdminFormAdd";
            this.btnAdminFormAdd.Size = new System.Drawing.Size(148, 71);
            this.btnAdminFormAdd.TabIndex = 0;
            this.btnAdminFormAdd.Text = "ADD EMPLOYEE";
            this.btnAdminFormAdd.UseVisualStyleBackColor = false;
            this.btnAdminFormAdd.Click += new System.EventHandler(this.btnAdminFormAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(38, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(878, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "TO DELETE,CLICK SHOW EMPLOYEE,SELECT A ROW AND PRESS DELETE";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 646);
            this.Controls.Add(this.pnlAdmin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            this.pnlEmpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAdmin;
        public System.Windows.Forms.Panel pnlEmpUserControls;
        private System.Windows.Forms.Panel pnlEmpButtons;
        private System.Windows.Forms.Button btnProfit;
        private System.Windows.Forms.Button btnAdminFormShow;
        private System.Windows.Forms.Button btnAdminFormAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}