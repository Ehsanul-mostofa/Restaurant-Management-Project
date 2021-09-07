using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            DataAccess da = new DataAccess();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlLogin.BackColor = Color.FromArgb(80, 0, 0, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Admin a1 = new Admin();
            Manager m1 = new Manager();

            DataAccess da = new DataAccess();
            try
            {
                string sql = "select department from employee where id='" + this.txtUserName.Text + "' and password='" + this.txtPassword.Text + "'";
                DataSet ds = da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows[0][0].ToString() == "admin")
                {
                    a1.Visible = true;
                    this.Visible = false;
                }
                else if (ds.Tables[0].Rows[0][0].ToString() == "manager")
                {
                    m1.Visible = true;
                    this.Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("invalid id or password");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtUserName.Text = "";
            this.txtPassword.Text = "";
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
