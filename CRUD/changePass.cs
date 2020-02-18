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

            oldPass.PasswordChar = '\u0000';
            newPass.PasswordChar = '\u0000';
            username.Text = "Username";
            oldPass.Text = "Current Password";
            newPass.Text = "New Password";
            panel1.BackColor = System.Drawing.Color.White;
            username.ForeColor = System.Drawing.Color.DarkGray;
            panel2.BackColor = System.Drawing.Color.White;
            oldPass.ForeColor = System.Drawing.Color.DarkGray;
            panel3.BackColor = System.Drawing.Color.White;
            newPass.ForeColor = System.Drawing.Color.DarkGray;

        }
        private void returnPage()
        {
            this.Hide();
            Login mm = new Login();
            mm.Show();
        }

        private void changePass_Load(object sender, EventArgs e)
        {

        }

        private void username_Enter(object sender, EventArgs e)
        {
            if(username.Text == "Username")
            {
                panel1.BackColor = System.Drawing.Color.ForestGreen;
                username.ForeColor = System.Drawing.Color.White;
                username.Text = "";
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                panel1.BackColor = System.Drawing.Color.White;
                username.ForeColor = System.Drawing.Color.DarkGray;
                username.Text = "Username";
            }
        }

        private void oldPass_Enter(object sender, EventArgs e)
        {
            if(oldPass.Text == "Current Password")
            {
                panel2.BackColor = System.Drawing.Color.ForestGreen;
                oldPass.PasswordChar = '*';
                oldPass.Text = "";
                oldPass.ForeColor = System.Drawing.Color.White;
            }
        }

        private void oldPass_Leave(object sender, EventArgs e)
        {
            if (oldPass.Text == "")
            {
                panel2.BackColor = System.Drawing.Color.White;
                oldPass.ForeColor = System.Drawing.Color.DarkGray;
                oldPass.PasswordChar = '\u0000';
                oldPass.Text = "Current Password";
            }
        }

        private void newPass_Enter(object sender, EventArgs e)
        {
            if (newPass.Text == "New Password")
            {
                panel3.BackColor = System.Drawing.Color.ForestGreen;
                newPass.PasswordChar = '*';
                newPass.Text = "";
                newPass.ForeColor = System.Drawing.Color.White;
            }
        }

        private void newPass_Leave(object sender, EventArgs e)
        {
            if (newPass.Text == "")
            {
                panel3.BackColor = System.Drawing.Color.White;
                newPass.ForeColor = System.Drawing.Color.DarkGray;
                newPass.PasswordChar = '\u0000';
                newPass.Text = "New Password";
            }
        }
    }
 }
