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
    public partial class Sec3 : Form
    {
        public Sec3()
        {
            InitializeComponent();
        }

        private void Sec3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cpe5thyearDataSetSec3.Sec3' table. You can move, or remove it, as needed.
            this.sec3TableAdapter.Fill(this.cpe5thyearDataSetSec3.Sec3);

        }
    }
}
