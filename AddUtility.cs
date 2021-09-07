using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class AddUtility : UserControl
    {
        private DataAccess Da { get; set; }
        public AddUtility()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (this.txtMonth.Text == "" || this.txtGas.Text == "" || this.txtElectricity.Text=="" || this.txtWater.Text=="" || this.txtOther.Text=="")
            {
                MessageBox.Show("Fill up all texts");
            }
            else
            {
                string sql = "insert into utility values('" + this.txtMonth.Text + "','" + this.txtGas.Text + "','" + this.txtElectricity.Text + "','" + this.txtWater.Text + "','" + this.txtOther.Text + "')";
                int row = this.Da.ExecuteUpdateQuery(sql);

                if (row == 1)
                {
                    MessageBox.Show("data inserted successfully");
                }
                else
                {
                    MessageBox.Show("Error");
                }


            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtMonth.Text = "";
            this.txtElectricity.Text = "";
            this.txtGas.Text = "";
            this.txtWater.Text = "";
            this.txtOther.Text = "";
            
        }
    }
}
