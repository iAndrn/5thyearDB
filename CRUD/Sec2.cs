using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CRUD
{
    public partial class Sec2 : Form
    {
        public Sec2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4B08G427\SQLEXPRESS;Initial Catalog=Cpe5thyear;Integrated Security=True");
        private void Sec2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cpe5thyearDataSetSec2.Sec2' table. You can move, or remove it, as needed.
            this.sec2TableAdapter.Fill(this.cpe5thyearDataSetSec2.Sec2);
            // TODO: This line of code loads data into the 'cPEDataSetSec2.Sec2' table. You can move, or remove it, as needed.
            

            GetStudentsRecord();

        }
        private void GetStudentsRecord()
        {

            SqlCommand cmd = new SqlCommand("Select * From Sec2", conn);
            DataTable dt = new DataTable();
            conn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();

            StudentDataGridView.DataSource = dt;
        }

        private void Sec2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Login mm = new Login();
            mm.Show();
        }

        public void searchFname(string findValue)
        {
            string searchQuery = "SELECT * FROM Sec2 WHERE (FirstName) LIKE '%" + findValue + "%'";
            SqlDataAdapter adpt = new SqlDataAdapter(searchQuery, conn);
            DataTable table = new DataTable();
            adpt.Fill(table);
            StudentDataGridView.DataSource = table;

        }
        public void searchLname(string findValue)
        {
            string searchQuery = "SELECT * FROM Sec2 WHERE (LastName) LIKE '%" + findValue + "%'";
            SqlDataAdapter adpt = new SqlDataAdapter(searchQuery, conn);
            DataTable table = new DataTable();
            adpt.Fill(table);
            StudentDataGridView.DataSource = table;

        }
        public void searchstudentNum(string findValue)
        {
            string searchQuery = "SELECT * FROM Sec2 WHERE (StudentNum) LIKE '%" + findValue + "%'";
            SqlDataAdapter adpt = new SqlDataAdapter(searchQuery, conn);
            DataTable table = new DataTable();
            adpt.Fill(table);
            StudentDataGridView.DataSource = table;

        }




        private void searchtextstudentNum_TextChanged(object sender, EventArgs e)
        {
            searchstudentNum(searchtextstudentNum.Text);
        }

        private void searchTextFname_TextChanged(object sender, EventArgs e)
        {
            searchFname(searchTextFname.Text);
        }

        private void searchTextLname_TextChanged(object sender, EventArgs e)
        {
            searchLname(searchTextLname.Text);
        }






        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void StudentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Fname.Text = StudentDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            Lname.Text = StudentDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            studentNum.Text = StudentDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            emailAdd.Text = StudentDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            contactNum.Text = StudentDataGridView.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
