using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CRUD
{
    public partial class Sec3 : Form
    {
        public Sec3()
        {
            InitializeComponent();
        }

        private void Sec3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cpe5thyearDataSetSec3.Sec3' table. You can move, or remove it, as needed.
            this.sec3TableAdapter.Fill(this.cpe5thyearDataSetSec3.Sec3);
            GetStudentsRecord();

        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4B08G427\SQLEXPRESS;Initial Catalog=Cpe5thyear;Integrated Security=True");
        private void GetStudentsRecord()
        {

            SqlCommand cmd = new SqlCommand("Select * From Sec3", conn);
            DataTable dt = new DataTable();
            conn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();

            StudentDataGridView.DataSource = dt;
        }

        public void searchFname(string findValue)
        {
            string searchQuery = "SELECT * FROM Sec3 WHERE (FirstName) LIKE '%" + findValue + "%'";
            SqlDataAdapter adpt = new SqlDataAdapter(searchQuery, conn);
            DataTable table = new DataTable();
            adpt.Fill(table);
            StudentDataGridView.DataSource = table;

        }
        public void searchLname(string findValue)
        {
            string searchQuery = "SELECT * FROM Sec3 WHERE (LastName) LIKE '%" + findValue + "%'";
            SqlDataAdapter adpt = new SqlDataAdapter(searchQuery, conn);
            DataTable table = new DataTable();
            adpt.Fill(table);
            StudentDataGridView.DataSource = table;

        }
        public void searchstudentNum(string findValue)
        {
            string searchQuery = "SELECT * FROM Sec3 WHERE (StudentNum) LIKE '%" + findValue + "%'";
            SqlDataAdapter adpt = new SqlDataAdapter(searchQuery, conn);
            DataTable table = new DataTable();
            adpt.Fill(table);
            StudentDataGridView.DataSource = table;

        }

        private void searchTextFname_TextChanged(object sender, EventArgs e)
        {
            searchFname(searchTextFname.Text);
        }

        private void searchTextLname_TextChanged(object sender, EventArgs e)
        {
            searchLname(searchTextLname.Text);
        }

        private void searchtextstudentNum_TextChanged(object sender, EventArgs e)
        {
            searchstudentNum(searchtextstudentNum.Text);
        }

        private void Sec3_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Login mm = new Login();
            mm.Show();
        }

        private void StudentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Fname.Text = StudentDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            Lname.Text = StudentDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            Mname.Text = StudentDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            studentNum.Text = StudentDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            emailAdd.Text = StudentDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            contactNum.Text = StudentDataGridView.SelectedRows[0].Cells[6].Value.ToString();
        }
    }
}
