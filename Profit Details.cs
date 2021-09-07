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
    public partial class Profit_Details : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public Profit_Details()
        {
            InitializeComponent();
            this.Da = new DataAccess();
          
        }

        private void btnShowSales_Click(object sender, EventArgs e)
        {
            if (cmbMonth.Text == "month" || cmbMonth.Text == "" || cmbYear.Text == "year" || cmbYear.Text == "")
            {
                MessageBox.Show("please fill up month and year");
            }
            else
            {

                string sql = "select sum(amount) from sales where month(ondate) = " + cmbMonth.Text + " and year(ondate)= " + cmbYear.Text + ";";
                DataSet Ds = Da.ExecuteQuery(sql);
                this.txtSales.Text = Ds.Tables[0].Rows[0][0].ToString();

                string sql1 = "select sum(price) from purchase where month(purchasedate) = " + cmbMonth.Text + " and year(purchasedate)= " + cmbYear.Text + ";";
                DataSet Ds1 = Da.ExecuteQuery(sql1);
                this.txtPurchase.Text = Ds1.Tables[0].Rows[0][0].ToString();

                string sql2 = "select gasbill + electricitybill + waterbill + others from utility where month(month) = " + cmbMonth.Text + " and year(month)=" + cmbYear.Text + "";
                DataSet Ds2 = Da.ExecuteQuery(sql2);
                this.txtUtility.Text = Ds2.Tables[0].Rows[0][0].ToString();

                string sql3 = "select sum(salary) from Employee";
                DataSet Ds3 = Da.ExecuteQuery(sql3);
                this.txtSal.Text = Ds3.Tables[0].Rows[0][0].ToString();

                this.txtProLoss.Text = (Convert.ToDouble(this.txtSales.Text) - (Convert.ToDouble(this.txtPurchase.Text) + Convert.ToDouble(this.txtSal.Text) + Convert.ToDouble(this.txtUtility.Text))).ToString();


            }


        }
    }
}
