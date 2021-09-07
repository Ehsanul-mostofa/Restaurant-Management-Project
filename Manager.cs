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
    public partial class Manager : Form
    {
        internal static Billing B1 { get; set; }
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public Manager()
        {
            InitializeComponent();
            this.Da = new DataAccess();

        }



        private void Manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItem a1 = new AddItem();
            this.pnlPrime.Controls.Add(a1);
            a1.BringToFront();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            GridviewItem g1 = new GridviewItem(this);
            this.pnlGridPrime.Controls.Add(g1);
            g1.BringToFront();

        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRawMat_Click(object sender, EventArgs e)
        {
            AddRawMaterials a2 = new AddRawMaterials();
            this.pnlPrime.Controls.Add(a2);
            a2.BringToFront();
        }

        private void btnGridPurchase_Click(object sender, EventArgs e)
        {
            PurchaseGridView p1 = new PurchaseGridView(this);
            this.pnlGridPrime.Controls.Add(p1);
            p1.BringToFront();
        }

        private void btnAddUtility_Click(object sender, EventArgs e)
        {
            AddUtility a3 = new AddUtility();
            this.pnlPrime.Controls.Add(a3);
            a3.BringToFront();

        }

        private void btnGridPur_Click(object sender, EventArgs e)
        {
            GridUtility p2 = new GridUtility(this);
            this.pnlGridPrime.Controls.Add(p2);
            p2.BringToFront();
        }

        
        
        private void btnBilling_Click(object sender, EventArgs e)
        {
  
            if(B1 !=null){
               B1.Visible = true;
            }
            else
            {
                B1=new Billing();
                B1.Visible = true;
            }
            
        }
    

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            this.Visible = false;
            l1.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
