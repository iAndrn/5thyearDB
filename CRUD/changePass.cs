using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace CRUD
{

    public partial class changePass : Form
    {
        
        public changePass()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4B08G427\SQLEXPRESS;Initial Catalog=Cpe5thyear;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM admin WHERE adminUser ='" + username.Text + "' and adminPass='" + oldPass.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {


                  
                    SqlCommand cmd = new SqlCommand("UPDATE admin SET adminPass = @adminPass WHERE @adminUser = adminUser ", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@adminUser", username.Text);
                    cmd.Parameters.AddWithValue("@adminPass", newPass.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                   MessageBox.Show("Successfully Changed Admins Password", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   MessageBox.Show("Exit Window to Return to Login", "Return", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                   returnPage();




            }
            else
            {
                MessageBox.Show("Enter Correct Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void changePass_FormClosing(object sender, FormClosingEventArgs e)
        {
            returnPage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            username.Clear();
            oldPass.Clear();
            newPass.Clear();

        }
        private void returnPage()
        {
            this.Hide();
            Login mm = new Login();
            mm.Show();
        }
    }
}
