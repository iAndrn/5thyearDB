using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace CRUD
{
    public partial class GlobalSearch : Form
    {
        public GlobalSearch()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4B08G427\SQLEXPRESS;Initial Catalog=Cpe5thyear;Integrated Security=True");
        private void GlobalDatabase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cpe5thyearDataSetGlobalSearch.OverallSec' table. You can move, or remove it, as needed.
            this.overallSecTableAdapter.Fill(this.cpe5thyearDataSetGlobalSearch.OverallSec);
            GetStudentsRecord();

        }

        private void GetStudentsRecord()
        {

            SqlCommand cmd = new SqlCommand("Select * From OverallSec", conn);
            DataTable dt = new DataTable();
            conn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();

            StudentDataGridView.DataSource = dt;
        }

        public void searchFname(string findValue)
        {
           /* if (findValue == "'")
            {
                findValue = "";
            }*/
            string searchQuery = "SELECT * FROM OverallSec WHERE (FirstName) LIKE '%" + findValue + "%'";
            SqlDataAdapter adpt = new SqlDataAdapter(searchQuery, conn);
            DataTable table = new DataTable();
            adpt.Fill(table);
            StudentDataGridView.DataSource = table;

        }
        public void searchLname(string findValue)
        {
            string searchQuery = "SELECT * FROM OverallSec WHERE (LastName) LIKE '%" + findValue + "%'";
            SqlDataAdapter adpt = new SqlDataAdapter(searchQuery, conn);
            DataTable table = new DataTable();
            adpt.Fill(table);
            StudentDataGridView.DataSource = table;

        }
        public void searchstudentNum(string findValue)
        {
            string searchQuery = "SELECT * FROM OverallSec WHERE (StudentNum) LIKE '%" + findValue + "%'";
            SqlDataAdapter adpt = new SqlDataAdapter(searchQuery, conn);
            DataTable table = new DataTable();
            adpt.Fill(table);
            StudentDataGridView.DataSource = table;

        }
        public void searchsectionNum(string findValue)
        {
            string searchQuery = "SELECT * FROM OverallSec WHERE (SectionNum) LIKE '%" + findValue + "%'";
            SqlDataAdapter adpt = new SqlDataAdapter(searchQuery, conn);
            DataTable table = new DataTable();
            adpt.Fill(table);
            StudentDataGridView.DataSource = table;

        }



 

 

        private void searchTextFname_TextChanged(object sender, EventArgs e)
        {
            searchFname(searchTextFname.Text);
            panel1.BackColor = System.Drawing.Color.ForestGreen;
            panel2.BackColor = System.Drawing.Color.White;
            panel3.BackColor = System.Drawing.Color.White;
            panel4.BackColor = System.Drawing.Color.White;
        }
        private void searchTextLname_TextChanged(object sender, EventArgs e)
        {
            searchLname(searchTextLname.Text);
            panel1.BackColor = System.Drawing.Color.White;
            panel2.BackColor = System.Drawing.Color.ForestGreen;
            panel3.BackColor = System.Drawing.Color.White;
            panel4.BackColor = System.Drawing.Color.White;
        }
        private void sectionNum_TextChanged(object sender, EventArgs e)
        {
            searchsectionNum(searchtextSecNum.Text);
            panel1.BackColor = System.Drawing.Color.White;
            panel2.BackColor = System.Drawing.Color.White;
            panel3.BackColor = System.Drawing.Color.White;
            panel4.BackColor = System.Drawing.Color.ForestGreen;
        }

        private void searchtextstudentNum_TextChanged(object sender, EventArgs e)
        {
            searchstudentNum(searchtextstudentNum.Text);
            panel1.BackColor = System.Drawing.Color.White;
            panel2.BackColor = System.Drawing.Color.White;
            panel3.BackColor = System.Drawing.Color.ForestGreen;
            panel4.BackColor = System.Drawing.Color.White;
        }

        private void StudentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Fname.Text = StudentDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            Lname.Text = StudentDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            Mname.Text = StudentDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            studentNum.Text = StudentDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            SectionNum.Text = StudentDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            emailAdd.Text = StudentDataGridView.SelectedRows[0].Cells[6].Value.ToString();
            contactNum.Text = StudentDataGridView.SelectedRows[0].Cells[7].Value.ToString();

        }

        private void sectionNum_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {

                e.Handled = true;
            }
        }




        private void GlobalSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Login mm = new Login();
            mm.Show();
        }
    }
}
