using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace CRUD
{
    public partial class Sec1 : Form
    {
        public Sec1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4B08G427\SQLEXPRESS;Initial Catalog=Cpe5thyear;Integrated Security=True");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetSec1.Sec1' table. You can move, or remove it, as needed.
            this.sec1TableAdapter.Fill(this.dataSetSec1.Sec1);


            GetStudentsRecord();
        }

        private void GetStudentsRecord()
        {
            
            SqlCommand cmd = new SqlCommand("Select * From Sec1", conn);
            DataTable dt = new DataTable();
            conn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();

            StudentDataGridView.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Sec1 VALUES (@FirstName, @LastName, @StudentNum, @emailAdd, @contactNum)", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FirstName", Fname.Text);
                cmd.Parameters.AddWithValue("@LastName", Lname.Text);
                cmd.Parameters.AddWithValue("@StudentNum", StudentNum.Text);
                cmd.Parameters.AddWithValue("@emailAdd", emailAdd.Text);
                cmd.Parameters.AddWithValue("@contactNum", contactNum.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Added New Student", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStudentsRecord();
            }
        }

        private bool IsValid()
        {
            if (Fname.Text == string.Empty)
            {
                MessageBox.Show("First Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            return true;
        }

        private void Sec1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Login mm = new Login();
            mm.Show();
        }


        public void searchFname(string findValue)
        {
            string searchQuery = "SELECT * FROM Sec1 WHERE (FirstName) LIKE '%" + findValue + "%'";
            SqlDataAdapter adpt = new SqlDataAdapter(searchQuery, conn);
            DataTable table = new DataTable();
            adpt.Fill(table);
            StudentDataGridView.DataSource = table;

        }
        public void searchLname(string findValue)
        {
            string searchQuery = "SELECT * FROM Sec1 WHERE (LastName) LIKE '%" + findValue + "%'";
            SqlDataAdapter adpt = new SqlDataAdapter(searchQuery, conn);
            DataTable table = new DataTable();
            adpt.Fill(table);
            StudentDataGridView.DataSource = table;

        }
        public void searchstudentNum(string findValue)
        {
            string searchQuery = "SELECT * FROM Sec1 WHERE (StudentNum) LIKE '%" + findValue + "%'";
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void searchTextFname_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void StudentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contactNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
