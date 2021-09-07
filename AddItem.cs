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

    public partial class AddItem : UserControl
    {
        private DataAccess Da { get; set; }
        
        public AddItem()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            AutoIdGenerate();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(txtId.Text=="" || txtName.Text=="" || txtPrice.Text=="" || txtType.Text == "")
            {
                MessageBox.Show("Fill up all texts");
            }
            else
            {
                string sql = "insert into Item values('" + this.txtId.Text + "','" + this.txtName.Text + "','" + this.txtType.Text + "'," + this.txtPrice.Text + ")";
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
        private void AutoIdGenerate()
        {
            string sql = "select id from Item order by id desc;";
            DataTable dt = this.Da.ExecuteQueryTable(sql);
            string previousId = dt.Rows[0][0].ToString();
            string[] temp = previousId.Split('-');
            int serialNo = Convert.ToInt32(temp[1]);
            string nextId = "i-" + (++serialNo).ToString("00");
            this.txtId.Text = nextId;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.AutoIdGenerate();
            this.txtName.Text = "";
            this.txtPrice.Text = "";
            this.txtType.Text = "";
        }

        private void AddItem_Load(object sender, EventArgs e)
        {

        }
    }
}
