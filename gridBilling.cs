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
    public partial class GridBilling : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }


        public GridBilling()
        {
            InitializeComponent();
            Da = new DataAccess();
        }


        internal void PopulateGridview()
        {
            string sql = "select * from billings";
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = Ds.Tables[0];
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string sl = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string sql = "delete from billings where sl=" + sl + "";
            int row = this.Da.ExecuteUpdateQuery(sql);
            if (row == 1)
            {
                MessageBox.Show("item has been removed");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            PopulateGridview();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            txtAmount.Text = sum.ToString();

            string sql = "insert into sales values(" + this.txtAmount.Text + ",GETDATE())";
            int row = this.Da.ExecuteUpdateQuery(sql);

            if (row == 1)
            {
                MessageBox.Show("sale emount enlisted successfully");
            }
            else
            {
                MessageBox.Show("Error");
            }
            string sql1 = "delete from billings";
            int row1 = this.Da.ExecuteUpdateQuery(sql1);
 
                MessageBox.Show("billings reorganized! Click Show to refresh");



        }
    }
}
