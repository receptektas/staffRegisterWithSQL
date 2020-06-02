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
    public partial class frmMainPage : Form
    {
        public frmMainPage()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-919AS9O;Initial Catalog=personelDB-2;Integrated Security=True");

        public void clearAll(){
            txtId.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            cmbCity.Text = "";
            rdSingle.Checked = false;
            rdMarried.Checked = false;
            txtJob.Text = "";
            msktxtWage.Text = "";
            txtName.Focus();

        }

        public void list() {
            this.tblPersonel_3TableAdapter.Fill(this._personelDB_2DataSet._tblPersonel_3);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.tblPersonel_3TableAdapter.Fill(this._personelDB_2DataSet._tblPersonel_3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tblPersonel_3TableAdapter.Fill(this._personelDB_2DataSet._tblPersonel_3);
        }

        string maritialStatus;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            maritialStatus = "False";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            maritialStatus = "True";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            connect.Open();

            SqlCommand commend = new SqlCommand("insert into [tblPersonel-3] (Name,Surname,City,Salary,Maritial,Job) values (@p1,@p2,@p3,@p4,@p5,@p6)", connect);

            commend.Parameters.AddWithValue("@p1", txtName.Text);
            commend.Parameters.AddWithValue("@p2", txtSurname.Text);
            commend.Parameters.AddWithValue("@p3", cmbCity.Text);
            commend.Parameters.AddWithValue("@p4", msktxtWage.Text);
            commend.Parameters.AddWithValue("@p5", maritialStatus);
            commend.Parameters.AddWithValue("@p6", txtJob.Text);
            commend.ExecuteNonQuery();
            connect.Close();
            list();
            MessageBox.Show("Personnel Added. ");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }


        // The data clicked on the DataGrid writes the information into the boxes.
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int choosen = dataGridView1.SelectedCells[0].RowIndex;

            txtId.Text = dataGridView1.Rows[choosen].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[choosen].Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[choosen].Cells[2].Value.ToString();
            cmbCity.Text = dataGridView1.Rows[choosen].Cells[3].Value.ToString();
            msktxtWage.Text = dataGridView1.Rows[choosen].Cells[6].Value.ToString();
            txtJob.Text = dataGridView1.Rows[choosen].Cells[5].Value.ToString();
            if (dataGridView1.Rows[choosen].Cells[4].Value.ToString() == "True")
            {
                rdMarried.Checked = true;
            }
            else if (dataGridView1.Rows[choosen].Cells[4].Value.ToString() == "False")
            {
                rdSingle.Checked = true;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connect.Open();

            SqlCommand delete = new SqlCommand("Delete From [tblPersonel-3] Where Id=@p1", connect);
            delete.Parameters.AddWithValue("@p1", txtId.Text);
            delete.ExecuteNonQuery();
            connect.Close();
            list();
            MessageBox.Show("Personnel deleted!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connect.Open();

            SqlCommand update = new SqlCommand("Update [tblPersonel-3] Set Name=@Name, Surname=@Surname, City=@City, Salary=@Salary, Job=@Job where Id=@Id", connect);
            update.Parameters.AddWithValue("@Name", txtName.Text);
            update.Parameters.AddWithValue("@Surname", txtSurname.Text);
            update.Parameters.AddWithValue("@City", cmbCity.Text);
            update.Parameters.AddWithValue("@Salary", msktxtWage.Text);
            update.Parameters.AddWithValue("@Job", txtJob.Text);
            update.Parameters.AddWithValue("@Id", txtId.Text);
            update.ExecuteNonQuery();
            connect.Close();
            list();
            MessageBox.Show("Personel Updated!");
        }

        private void btnIstatistics_Click(object sender, EventArgs e)
        {
            frmIstatistic fr = new frmIstatistic();
            fr.Show();
        }

        private void btnGraphics_Click(object sender, EventArgs e)
        {
            frmGraphics frg = new frmGraphics();
            frg.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
