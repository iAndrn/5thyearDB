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
                else if (User.Text == "Sec6Admin")
                {
                    MessageBox.Show("Login Succesful Sec6Admin", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Sec6 mm = new Sec6();
                    this.Hide();

                    mm.Show();
                }
                else
                {
                    MessageBox.Show("Login Succesful GlobalAdmin", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GlobalSearch mm = new GlobalSearch();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void User_TextChanged(object sender, EventArgs e)
        {
            panel1.BackColor = System.Drawing.Color.ForestGreen;
            panel2.BackColor = System.Drawing.Color.White;
        }


/*        private void Pass_TextChanged(object sender, EventArgs e)
        {
            Pass.PasswordChar = '*';
            panel1.BackColor = System.Drawing.Color.White;
            panel2.BackColor = System.Drawing.Color.ForestGreen;
        }*/

        private void User_Enter(object sender, EventArgs e)
        {
            if(User.Text == "Username")
            {
                User.ForeColor = System.Drawing.Color.White;
                User.Text = "";
                panel1.BackColor = System.Drawing.Color.ForestGreen;

            }
        }

        private void User_Leave(object sender, EventArgs e)
        {
            if (User.Text == "")
            {
                User.ForeColor = System.Drawing.Color.DarkGray;
                User.Text = "Username";
                panel1.BackColor = System.Drawing.Color.White;

            }
        }

        private void Pass_Enter(object sender, EventArgs e)
        {
            
            if (Pass.Text == "Password")
            {
                panel2.BackColor = System.Drawing.Color.ForestGreen;
                Pass.ForeColor = System.Drawing.Color.White;
                Pass.PasswordChar = '*';
                Pass.Text = "";
                

            }
           
        }

        private void Pass_Leave(object sender, EventArgs e)
        {
            if (Pass.Text == "")
            {
                panel2.BackColor = System.Drawing.Color.White;
                Pass.ForeColor = System.Drawing.Color.DarkGray;
                Pass.PasswordChar = '\u0000';
                Pass.Text = "Password";
                
            }
        }
    }
}
