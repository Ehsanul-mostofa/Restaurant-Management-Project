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
    public partial class AddEmployee : UserControl
    {
        private DataAccess Da { get; set; }

        public AddEmployee()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            AutoIDGenerate();
        }

        private void btnEmpAdd_Click(object sender, EventArgs e)
        {
            if (txtIDEmp.Text == "" || txtNameEmp.Text == "" || txtAddressEmp.Text == "" || txtDeptEmp.Text == "" || txtSalEmp.Text == "" || this.dtpDate.Text == "" || txtContactEmp.Text == "")
            {
                MessageBox.Show("Fill up all texts");
            }
            else
            {
                string sql = "insert into Employee values('" + this.txtIDEmp.Text + "','" + this.txtNameEmp.Text + "','" + this.txtAddressEmp.Text + "','" + this.txtDeptEmp.Text + "'," + this.txtSalEmp.Text +",'"+ this.dtpDate.Text + "'," + this.txtContactEmp.Text + ",'"+this.txtPass.Text+"')";
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
            public void AutoIDGenerate()
            {
                string sql = "select id from Employee order by id desc;";
                DataTable dt = this.Da.ExecuteQueryTable(sql);
                string previousId = dt.Rows[0][0].ToString();
                string[] temp = previousId.Split('-');
                int serialNo = Convert.ToInt32(temp[1]);
                string nextId = "e-" + (++serialNo).ToString("00");
                this.txtIDEmp.Text = nextId;

            }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            AutoIDGenerate();
            this.txtAddressEmp.Text = "";
            this.txtContactEmp.Text = "";
            this.txtDeptEmp.Text = "";
            this.txtNameEmp.Text = "";
            this.txtPass.Text = "";
            this.dtpDate.Text = "";
            this.txtSalEmp.Text = "";
        }
    }
    }

