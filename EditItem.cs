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
    
    public partial class EditItem : UserControl
    {
        private DataAccess Da { get; set; }
        public EditItem()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            if (txtId.Text == "" || txtName.Text == "" || txtPrice.Text == "" || txtType.Text == "")
            {
                MessageBox.Show("Fill up all texts");
            }
            else
            {
                string sql = "update Item set name='" + this.txtName.Text + "',type='" + this.txtType.Text + "',price=" + this.txtPrice.Text + " where id='"+this.txtId.Text+"'";
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
