using System;
using System.Windows.Forms;

namespace CRUD
{
    public partial class GlobalSearch : Form
    {
        public GlobalSearch()
        {
            InitializeComponent();
        }

        private void GlobalDatabase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cpe5thyearDataSetGlobalDB.GlobalTable' table. You can move, or remove it, as needed.
            this.globalTableTableAdapter.Fill(this.cpe5thyearDataSetGlobalDB.GlobalTable);

        }

        private void searchTextFname_TextChanged(object sender, EventArgs e)
        {
            panel1.BackColor = System.Drawing.Color.ForestGreen;
            panel2.BackColor = System.Drawing.Color.White;
            panel3.BackColor = System.Drawing.Color.White;
            panel4.BackColor = System.Drawing.Color.White;
        }

        private void searchTextFname_Click(object sender, EventArgs e)
        {
            
        }

        private void searchTextLname_Click(object sender, EventArgs e)
        {
           
            panel1.BackColor = System.Drawing.Color.ForestGreen;
            panel2.BackColor = System.Drawing.Color.White;
            panel3.BackColor = System.Drawing.Color.White;
            panel4.BackColor = System.Drawing.Color.White;
        }

        private void sectionNum_TextChanged(object sender, EventArgs e)
        {
            panel1.BackColor = System.Drawing.Color.White;
            panel2.BackColor = System.Drawing.Color.White;
            panel3.BackColor = System.Drawing.Color.White;
            panel4.BackColor = System.Drawing.Color.ForestGreen;
        }

        private void searchTextLname_TextChanged(object sender, EventArgs e)
        {
            panel1.BackColor = System.Drawing.Color.White;
            panel2.BackColor = System.Drawing.Color.ForestGreen;
            panel3.BackColor = System.Drawing.Color.White;
            panel4.BackColor = System.Drawing.Color.White;
        }

        private void searchtextstudentNum_TextChanged(object sender, EventArgs e)
        {
            panel1.BackColor = System.Drawing.Color.White;
            panel2.BackColor = System.Drawing.Color.White;
            panel3.BackColor = System.Drawing.Color.ForestGreen;
            panel4.BackColor = System.Drawing.Color.White;
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
