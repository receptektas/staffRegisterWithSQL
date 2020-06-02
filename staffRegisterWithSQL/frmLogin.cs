using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace staffRegisterWithSQL
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-919AS9O;Initial Catalog=personelDB-2;Integrated Security=True");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connect.Open();

            SqlCommand cmd1 = new SqlCommand("Select * From tblLoginManage2 Where Username=@a1 and Password=@a2", connect);
            cmd1.Parameters.AddWithValue("@a1", txtUsername.Text);
            cmd1.Parameters.AddWithValue("@a2", txtPassword.Text);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read()) {
                frmMainPage fmp = new frmMainPage();
                fmp.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Wrong username or password! Please try again");
            }

            connect.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
