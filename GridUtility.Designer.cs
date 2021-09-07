
namespace RestaurantManagement
{
    partial class GridUtility
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridUtility));
            this.dgvShowItem = new System.Windows.Forms.DataGridView();
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gasbill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.electricitybill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterbill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.others = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSeach = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowItem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShowItem
            // 
            this.dgvShowItem.AllowUserToAddRows = false;
            this.dgvShowItem.AllowUserToDeleteRows = false;
            this.dgvShowItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.month,
            this.gasbill,
            this.electricitybill,
            this.waterbill,
            this.others});
            this.dgvShowItem.Location = new System.Drawing.Point(3, 151);
            this.dgvShowItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvShowItem.Name = "dgvShowItem";
            this.dgvShowItem.ReadOnly = true;
            this.dgvShowItem.RowHeadersWidth = 51;
            this.dgvShowItem.RowTemplate.Height = 24;
            this.dgvShowItem.Size = new System.Drawing.Size(655, 362);
            this.dgvShowItem.TabIndex = 6;
            this.dgvShowItem.DoubleClick += new System.EventHandler(this.dgvShowItem_DoubleClick);
            // 
            // month
            // 
            this.month.DataPropertyName = "month";
            this.month.HeaderText = "Month";
            this.month.MinimumWidth = 6;
            this.month.Name = "month";
            this.month.ReadOnly = true;
            this.month.Width = 125;
            // 
            // gasbill
            // 
            this.gasbill.DataPropertyName = "gasbill";
            this.gasbill.HeaderText = "Gas Bill";
            this.gasbill.MinimumWidth = 6;
            this.gasbill.Name = "gasbill";
            this.gasbill.ReadOnly = true;
            this.gasbill.Width = 125;
            // 
            // electricitybill
            // 
            this.electricitybill.DataPropertyName = "electricitybill";
            this.electricitybill.HeaderText = "Electricity Bill";
            this.electricitybill.MinimumWidth = 6;
            this.electricitybill.Name = "electricitybill";
            this.electricitybill.ReadOnly = true;
            this.electricitybill.Width = 125;
            // 
            // waterbill
            // 
            this.waterbill.DataPropertyName = "waterbill";
            this.waterbill.HeaderText = "Water bill";
            this.waterbill.MinimumWidth = 6;
            this.waterbill.Name = "waterbill";
            this.waterbill.ReadOnly = true;
            this.waterbill.Width = 125;
            // 
            // others
            // 
            this.others.DataPropertyName = "others";
            this.others.HeaderText = "Others";
            this.others.MinimumWidth = 6;
            this.others.Name = "others";
            this.others.ReadOnly = true;
            this.others.Width = 125;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteItem.Location = new System.Drawing.Point(489, 115);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(155, 32);
            this.btnDeleteItem.TabIndex = 11;
            this.btnDeleteItem.Text = "DELETE ITEM";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(201, 115);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 32);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSeach
            // 
            this.txtSeach.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSeach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtSeach.Location = new System.Drawing.Point(3, 115);
            this.txtSeach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSeach.Name = "txtSeach";
            this.txtSeach.Size = new System.Drawing.Size(190, 30);
            this.txtSeach.TabIndex = 9;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(10, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(302, 36);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "UTILITY GRIDVIEW";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(336, 115);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "SHOW ITEM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GridUtility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dgvShowItem);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSeach);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GridUtility";
            this.Size = new System.Drawing.Size(666, 535);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSeach;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn gasbill;
        private System.Windows.Forms.DataGridViewTextBoxColumn electricitybill;
        private System.Windows.Forms.DataGridViewTextBoxColumn waterbill;
        private System.Windows.Forms.DataGridViewTextBoxColumn others;
    }
}
