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
    }
}
