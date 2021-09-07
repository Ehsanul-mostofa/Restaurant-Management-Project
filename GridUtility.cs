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
    public partial class GridUtility : UserControl
    {
        private Manager M1 { get; set; }
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public GridUtility()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            string sql = "select * from utility";
            this.PopulateGridview(sql);
        }
        public GridUtility(Manager m1)
        {
            this.M1 = m1;
            InitializeComponent();
            this.Da = new DataAccess();
            string sql = "select * from utility";
            this.PopulateGridview(sql);
        }
        private void PopulateGridview(string sql)
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvShowItem.AutoGenerateColumns = false;
            this.dgvShowItem.DataSource = Ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from utility";
            this.PopulateGridview(sql);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from utility where month like '" + this.txtSeach.Text + "%';";
            this.PopulateGridview(sql);
        }

        private void dgvShowItem_DoubleClick(object sender, EventArgs e)
        {
            EditUtility e3 = new EditUtility();
            M1.pnlPrime.Controls.Add(e3);
            e3.BringToFront();
            e3.txtMonth.Text = this.dgvShowItem.CurrentRow.Cells[0].Value.ToString();
            e3.txtGas.Text = this.dgvShowItem.CurrentRow.Cells[1].Value.ToString();
            e3.txtElectricity.Text = this.dgvShowItem.CurrentRow.Cells[2].Value.ToString();
            e3.txtWater.Text = this.dgvShowItem.CurrentRow.Cells[3].Value.ToString();
            e3.txtOther.Text = this.dgvShowItem.CurrentRow.Cells[4].Value.ToString();

        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            string month = this.dgvShowItem.CurrentRow.Cells[0].Value.ToString();
            
            string sql = "delete from utility where month='" + month + "'";
            int row = this.Da.ExecuteUpdateQuery(sql);
            if (row == 1)
            {
                MessageBox.Show("" + month + " utility has been deleted");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
