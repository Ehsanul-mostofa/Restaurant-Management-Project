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
    public partial class Billing : Form
    {

        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public Billing()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            string sql = "select * from item";
            this.PopulateGridview(sql);
        }

        private void PopulateGridview(string sql)
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvShowItem.AutoGenerateColumns = false;
            this.dgvShowItem.DataSource = Ds.Tables[0];
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Item where name like '" + this.txtSeach.Text + "%';";
            this.PopulateGridview(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from item";
            this.PopulateGridview(sql);
        }

        private void dgvShowItem_DoubleClick(object sender, EventArgs e)
        {
            AutoIdGenerate();
            this.txtItem.Text= this.dgvShowItem.CurrentRow.Cells[1].Value.ToString();
            this.txtPrice.Text= this.dgvShowItem.CurrentRow.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtItem.Text == "" || txtQty.Text == "" || txtPrice.Text == "" )
            {
                MessageBox.Show("Fill up all texts");
            }
            else
            {
                string sql = "insert into billings values(" + this.txtSerial.Text + ",'" + this.txtItem.Text + "'," + this.txtQty.Text + "," + this.txtQty.Text + "*" + this.txtPrice.Text + ")";
                int row = this.Da.ExecuteUpdateQuery(sql);

                if (row == 1)
                {
                    MessageBox.Show("item enlisted successfully");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            GridBilling gb1 = new GridBilling();
            this.panel1.Controls.Add(gb1);
            gb1.BringToFront();
            gb1.PopulateGridview();

            
        }
        private void AutoIdGenerate()
        {
            string sql = "select sl from billings order by sl desc;";
            DataTable dt = this.Da.ExecuteQueryTable(sql);
            try
            {
                string previousId = dt.Rows[0][0].ToString();
                int serialNo = Convert.ToInt32(previousId);
                string nextId = Convert.ToInt32(++serialNo).ToString();
                this.txtSerial.Text = nextId;
            }
            catch {
                this.txtSerial.Text = 1.ToString();

            }
            
            

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //string item = this.dgvBilling.CurrentRow.Cells[0].Value.ToString();

        }

        private void btnShowChart_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AutoIdGenerate();
            this.txtItem.Text = "";
            this.txtQty.Text = "";
            this.txtPrice.Text = "";
        }

        private void Billing_FormClosed(object sender, FormClosedEventArgs e)
        {
            Manager.B1 = null;
        }
    }
}
