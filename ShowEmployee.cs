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
    public partial class ShowEmployee : UserControl
    {
       
        private Admin E1 { get; set; }
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public ShowEmployee()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            string sql = "select * from employee";
            this.PopulateGridview(sql);

        }
        public ShowEmployee(Admin e1)
        {
            this.E1 = e1;
            InitializeComponent();
            this.Da = new DataAccess();
            string sql = "select * from employee";
            this.PopulateGridview(sql);
        }
        private void PopulateGridview(string sql)
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvEmployeeDetails.AutoGenerateColumns = false;
            this.dgvEmployeeDetails.DataSource = Ds.Tables[0];
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            string sql = "select * from Employee where id like '" + this.txtEmpSearch.Text + "%';";
            this.PopulateGridview(sql);
        }

        private void btnShowEmpDetails_Click(object sender, EventArgs e)
        {
            string sql = "select * from Employee";
            this.PopulateGridview(sql);
        }

        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            string id = this.dgvEmployeeDetails.CurrentRow.Cells[0].Value.ToString();
            string name = this.dgvEmployeeDetails.CurrentRow.Cells[1].Value.ToString();
            string sql = "delete from Employee where id='" + id + "'";
            int row = this.Da.ExecuteUpdateQuery(sql);
            if (row == 1)
            {
                MessageBox.Show("" + name + " Employee has been deleted");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void dgvEmployeeDetails_DoubleClick(object sender, EventArgs e)
        {
            EditEmployee e2 = new EditEmployee();
            E1.pnlEmpUserControls.Controls.Add(e2);
            e2.BringToFront();
            e2.txtEmpID.Text = this.dgvEmployeeDetails.CurrentRow.Cells[0].Value.ToString();
            e2.txtEmpName.Text= this.dgvEmployeeDetails.CurrentRow.Cells[1].Value.ToString();
            e2.txtEmpAddress.Text= this.dgvEmployeeDetails.CurrentRow.Cells[2].Value.ToString();
            e2.txtEmpDept.Text= this.dgvEmployeeDetails.CurrentRow.Cells[3].Value.ToString();
            e2.txtEmpSalary.Text= this.dgvEmployeeDetails.CurrentRow.Cells[4].Value.ToString();
            e2.dtpEdit.Text= this.dgvEmployeeDetails.CurrentRow.Cells[5].Value.ToString();
            e2.txtEmpContact.Text= this.dgvEmployeeDetails.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
