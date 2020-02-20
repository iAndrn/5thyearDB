using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Sec1Update : Form
    {
        public Sec1Update()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4B08G427\SQLEXPRESS;Initial Catalog=Cpe5thyear;Integrated Security=True");
        private void Sec1Update_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cpe5thyearDataSetSec1.Sec1' table. You can move, or remove it, as needed.
            this.sec1TableAdapter.Fill(this.cpe5thyearDataSetSec1.Sec1);
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

        private void Sec1Update_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            UpdateLogin mm = new UpdateLogin();
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
        public int ID;
        private void StudentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(StudentDataGridView.SelectedRows[0].Cells[0].Value);
            Fname.Text = StudentDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            Lname.Text = StudentDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            Mname.Text = StudentDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            studentNum.Text = StudentDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            emailAdd.Text = StudentDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            contactNum.Text = StudentDataGridView.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if(ID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Sec1 SET FirstName = @FirstName, LastName = @LastName, MiddleName = @MiddleName, StudentNum =  @StudentNum,emailAdd = @emailAdd,contactNum = @contactNum WHERE id = @ID", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FirstName", Fname.Text);
                cmd.Parameters.AddWithValue("@LastName", Lname.Text);
                cmd.Parameters.AddWithValue("@MiddleName", Mname.Text);
                cmd.Parameters.AddWithValue("@StudentNum", studentNum.Text);
                cmd.Parameters.AddWithValue("@emailAdd", emailAdd.Text);
                cmd.Parameters.AddWithValue("@contactNum", contactNum.Text);
                
                cmd.Parameters.AddWithValue("@ID", this.ID);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Updated Student Information", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStudentsRecord();
                

                Fname.Clear();
                Lname.Clear();
                Mname.Clear();
                studentNum.Clear();
                emailAdd.Clear();
                contactNum.Clear();
                ID = 0;

            }
            else
            {
                MessageBox.Show("Select Student to Update", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void contactNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {

                Fname.Clear();
                Lname.Clear();
                Mname.Clear();
                studentNum.Clear();
                emailAdd.Clear();
                contactNum.Clear();
                SqlCommand cmd = new SqlCommand("UPDATE Sec1 SET FirstName = @FirstName, LastName = @LastName, MiddleName = @MiddleName, StudentNum =  @StudentNum,emailAdd = @emailAdd,contactNum = @contactNum WHERE id = @ID", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FirstName", Fname.Text);
                cmd.Parameters.AddWithValue("@LastName", Lname.Text);
                cmd.Parameters.AddWithValue("@MiddleName", Mname.Text);
                cmd.Parameters.AddWithValue("@StudentNum", studentNum.Text);
                cmd.Parameters.AddWithValue("@emailAdd", emailAdd.Text);
                cmd.Parameters.AddWithValue("@contactNum", contactNum.Text);

                cmd.Parameters.AddWithValue("@ID", this.ID);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Deleted Student Information", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStudentsRecord();


                ID = 0;
            }
        }
    }
}
