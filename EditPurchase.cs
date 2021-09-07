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
    public partial class EditPurchase : UserControl
    {
        private DataAccess Da { get; set; }
        public EditPurchase()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            if (txtId.Text == "" || txtName.Text == "" || txtPrice.Text == "" || this.txtQuantity.Text=="" || txtPur.Text.Length == 0 || txtExp.Text.Length == 0)
            {
                MessageBox.Show("Fill up all texts");
            }
            else
            {
                string sql = "update purchase set name='" + this.txtName.Text + "',quantity='" + this.txtQuantity.Text + "',price=" + this.txtPrice.Text + ",purchasedate='"+this.txtPur.Text+"',expiredate='"+this.txtExp.Text+"' where id='" + this.txtId.Text + "'";
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

        private void EditPurchase_Load(object sender, EventArgs e)
        {

        }
    }
}
