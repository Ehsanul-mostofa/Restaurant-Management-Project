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
    public partial class Admin : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public Admin()
        {
            InitializeComponent();
            this.Da = new DataAccess();

        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            pnlAdmin.BackColor = Color.FromArgb(80, 0, 0, 0);
        }

        private void btnAdminFormAdd_Click(object sender, EventArgs e)
        {
            AddEmployee e1 = new AddEmployee();
            this.pnlEmpUserControls.Controls.Add(e1);
            e1.BringToFront();
        }

        private void btnAdminFormEdit_Click(object sender, EventArgs e)
        {
 

        }

        private void btnAdminFormShow_Click(object sender, EventArgs e)
        {
            ShowEmployee s1 = new ShowEmployee(this);
            this.pnlEmpUserControls.Controls.Add(s1);
            s1.BringToFront();
        }

        private void btnProfit_Click(object sender, EventArgs e)
        {
            Profit_Details p1 = new Profit_Details();
            this.pnlEmpUserControls.Controls.Add(p1);
            p1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            this.Visible = false;
            l1.Visible = true;


        }

        private void pnlEmpUserControls_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
