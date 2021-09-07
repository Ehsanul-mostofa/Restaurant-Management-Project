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
    public partial class GridviewItem : UserControl
    {
        private Manager M1 { get; set; }
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public GridviewItem()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            string sql = "select * from item";
            this.PopulateGridview(sql);
            
        }
        public GridviewItem(Manager m1)
        {
            this.M1 = m1;
            InitializeComponent();
            this.Da = new DataAccess();
            string sql = "select * from item";
            this.PopulateGridview(sql);
        }

        private void PopulateGridview(string sql){
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvShowItem.AutoGenerateColumns = false;
            this.dgvShowItem.DataSource = Ds.Tables[0];
        }



        private void GridviewItem_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from item";
            this.PopulateGridview(sql);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Item where name like '"+this.txtSeach.Text+"%';";
            this.PopulateGridview(sql);
        }

        private void dgvShowItem_DoubleClick(object sender, EventArgs e)
        {
            EditItem e1 = new EditItem();
            M1.pnlPrime.Controls.Add(e1);
            e1.BringToFront();
            e1.txtId.Text = this.dgvShowItem.CurrentRow.Cells[0].Value.ToString();
            e1.txtName.Text = this.dgvShowItem.CurrentRow.Cells[1].Value.ToString();
            e1.txtType.Text = this.dgvShowItem.CurrentRow.Cells[2].Value.ToString();
            e1.txtPrice.Text = this.dgvShowItem.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            string id = this.dgvShowItem.CurrentRow.Cells[0].Value.ToString();
            string name= this.dgvShowItem.CurrentRow.Cells[1].Value.ToString();
            string sql="delete from Item where id='"+id+"'";
            int row = this.Da.ExecuteUpdateQuery(sql);
            if (row == 1)
            {
                MessageBox.Show(""+name+" item has been deleted");
            }
            else
            {
                MessageBox.Show("Error");
            }


        }

        private void dgvShowItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
