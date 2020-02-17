using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace CRUD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4B08G427\SQLEXPRESS;Initial Catalog=Cpe5thyear;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM admin WHERE adminUser ='"+User.Text+"' and adminPass='"+Pass.Text+"'",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString()=="1")
            {

                if (User.Text == "Sec1Admin")
                {
                    MessageBox.Show("Login Succesful Sec1Admin", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Sec1 mm = new Sec1();
                    this.Hide();
                    
                    mm.Show();
                }
                else if (User.Text == "Sec2Admin") {
                    MessageBox.Show("Login Succesful Sec2Admin", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Sec2 mm = new Sec2();
                    this.Hide();

                    mm.Show();

                }
                else if (User.Text == "Sec3Admin")
                {
                    MessageBox.Show("Login Succesful Sec3Admin", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Sec3 mm = new Sec3();
                    this.Hide();

                    mm.Show();
                }
                else if (User.Text == "Sec4Admin")
                {
                    MessageBox.Show("Login Succesful Sec4Admin", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Sec4 mm = new Sec4();
                    this.Hide();

                    mm.Show();

                }
                else if (User.Text == "Sec5Admin")
                {
                    MessageBox.Show("Login Succesful Sec5Admin", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Sec5 mm = new Sec5();
                    this.Hide();

                    mm.Show();

                }
                else
                {
                    MessageBox.Show("Login Succesful Sec5Admin", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Sec6 mm = new Sec6();
                    this.Hide();

                    mm.Show();
                }




            }
            else
            {
                MessageBox.Show("Enter Correct Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exitFunc();

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            exitFunc();

        }
        private void exitFunc()
        {
            Environment.Exit(0);
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            changePass mm = new changePass();
            mm.Show();
        }
    }
}
