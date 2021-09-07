using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class EditEmployee : UserControl
    {
        private DataAccess Da { get; set; }
        public EditEmployee()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }


        private void btnEditEmp_Click(object sender, EventArgs e)
        {

            if (txtEmpID.Text == "" || txtEmpName.Text == "" || txtEmpAddress.Text == "" || txtEmpDept.Text == "" || txtEmpSalary.Text == "" || this.dtpEdit.Text == "" || txtEmpContact.Text == "")
            {
                MessageBox.Show("Fill up all texts");
            }
            else
            {
                string sql = "update Employee set name='" + txtEmpName.Text + "',address='" + txtEmpAddress.Text + "',department='" + txtEmpDept.Text + "',salary=" + txtEmpSalary.Text + ",hiredate='" + this.dtpEdit.Text + "',contact=" + txtEmpContact.Text + " where id='" + this.txtEmpID.Text + "'";
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