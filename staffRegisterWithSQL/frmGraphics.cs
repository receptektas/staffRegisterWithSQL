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
    public partial class frmGraphics : Form
    {
        public frmGraphics()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-919AS9O;Initial Catalog=personelDB-2;Integrated Security=True");

        private void frmGraphics_Load(object sender, EventArgs e)
        {
            connect.Open();

            SqlCommand cmd1 = new SqlCommand("Select City,count(*) From [tblPersonel-3] group by City", connect);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read()) {
                chart1.Series["Cities"].Points.AddXY(dr1[0], dr1[1]);
            }
            connect.Close();

            // graphForJob-Sale
            connect.Open();

            SqlCommand cmd2 = new SqlCommand("Select Job,avg(Salary) From [tblPersonel-3] group by Job", connect);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read()) {
                chart2.Series["Job-Salary"].Points.AddXY(dr2[0], dr2[1]);
            }

            connect.Close();





        }
    }
}
