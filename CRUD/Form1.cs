using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class GlobalDatabase : Form
    {
        public GlobalDatabase()
        {
            InitializeComponent();
        }

        private void GlobalDatabase_Load(object sender, EventArgs e)
        {

        }

        private void searchTextFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchTextFname_Click(object sender, EventArgs e)
        {
            label2.BackColor = System.Drawing.Color.White;
            label1.BackColor = System.Drawing.Color.ForestGreen;
            panel1.BackColor = System.Drawing.Color.ForestGreen;
            panel2.BackColor = System.Drawing.Color.White;
        }

        private void searchTextLname_Click(object sender, EventArgs e)
        {
            label2.BackColor = System.Drawing.Color.White;
            label2.BackColor = System.Drawing.Color.ForestGreen;
            panel1.BackColor = System.Drawing.Color.ForestGreen;
            panel2.BackColor = System.Drawing.Color.White;
        }
    }
}
