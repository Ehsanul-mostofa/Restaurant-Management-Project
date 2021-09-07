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
    public partial class EditUtility : UserControl
    {
        private DataAccess Da { get; set; }
        public EditUtility()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.txtMonth.Text == "" || this.txtGas.Text == "" || this.txtElectricity.Text == "" || this.txtWater.Text == "" || this.txtOther.Text == "")
            {
                MessageBox.Show("Fill up all texts");
            }
            else
            {
                string sql = "update utility set gasbill=" + this.txtGas.Text + ",electricitybill=" + this.txtElectricity.Text + ",waterbill=" + this.txtWater.Text + ",others=" + this.txtOther.Text + " where month='" + this.txtMonth.Text + "'";
                int row = this.Da.ExecuteUpdateQuery(sql);

                if (row == 1)
                {
                    MessageBox.Show("data edited successfully");
                }
                else if (row == 0)
                {
                    MessageBox.Show("check the date and other fields");

                }
                else
                {
                    MessageBox.Show("Error");
                }


            }

        }
    }
}
