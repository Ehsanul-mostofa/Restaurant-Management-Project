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
    public partial class PurchaseGridView : UserControl
    {
        private Manager M1 { get; set; }
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public PurchaseGridView()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            string sql = "select * from purchase";
            this.PopulateGridview(sql);
        }
        public PurchaseGridView(Manager m1)
        {
            this.M1 = m1;
            InitializeComponent();
            this.Da = new DataAccess();
            string sql = "select * from purchase";
            this.PopulateGridview(sql);
        }
        private void PopulateGridview(string sql)
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvShowPurchase.AutoGenerateColumns = false;
            this.dgvShowPurchase.DataSource = Ds.Tables[0];
        }

        private void dgvShowItem_DoubleClick(object sender, EventArgs e)
        {
            EditPurchase e2 = new EditPurchase();
            M1.pnlPrime.Controls.Add(e2);
            e2.BringToFront();
            e2.txtId.Text= this.dgvShowPurchase.CurrentRow.Cells[0].Value.ToString();
            e2.txtName.Text = this.dgvShowPurchase.CurrentRow.Cells[1].Value.ToString();
            e2.txtPrice.Text = this.dgvShowPurchase.CurrentRow.Cells[2].Value.ToString();
            e2.txtQuantity.Text = this.dgvShowPurchase.CurrentRow.Cells[3].Value.ToString();
            e2.txtPur.Text= this.dgvShowPurchase.CurrentRow.Cells[4].Value.ToString();
            e2.txtExp.Text= this.dgvShowPurchase.CurrentRow.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from purchase";
            this.PopulateGridview(sql);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from purchase where name like '" + this.txtSearch.Text + "%';";
            this.PopulateGridview(sql);
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            string id = this.dgvShowPurchase.CurrentRow.Cells[0].Value.ToString();
            string name = this.dgvShowPurchase.CurrentRow.Cells[1].Value.ToString();
            string sql = "delete from purchase where id='" + id + "'";
            int row = this.Da.ExecuteUpdateQuery(sql);
            if (row == 1)
            {
                MessageBox.Show("" + name + " item has been deleted");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
