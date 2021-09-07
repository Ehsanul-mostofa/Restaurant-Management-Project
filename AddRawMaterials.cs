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
    public partial class AddRawMaterials : UserControl
    {
        private DataAccess Da { get; set; }
        public AddRawMaterials()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.AutoIdGenerate();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtName.Text == "" || txtPrice.Text == "" || txtQuantity.Text == "" || txtPur.Text.Length==0 || txtExp.Text.Length==0)
            {
                MessageBox.Show("Fill up all texts");
            }
            else
            {
                string sql = "insert into purchase values('" + this.txtId.Text + "','" + this.txtName.Text + "','" + this.txtQuantity.Text + "','" + this.txtPur.Text + "','" + this.txtExp.Text + "'," + this.txtPrice.Text + ");";
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.AutoIdGenerate();
            this.txtName.Text = "";
            this.txtPrice.Text = "";
            this.txtQuantity.Text = "";
       
        }
        private void AutoIdGenerate()
        {
            string sql = "select id from purchase order by id desc;";
            DataTable dt = this.Da.ExecuteQueryTable(sql);
            string previousId = dt.Rows[0][0].ToString();
            string[] temp = previousId.Split('-');
            int serialNo = Convert.ToInt32(temp[1]);
            string nextId = "r-" + (++serialNo).ToString("00");
            this.txtId.Text = nextId;

        }
    }
}
