using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;

namespace CRUD
{
    public partial class UpdateLogin : Form
    {
        public UpdateLogin()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-4B08G427\SQLEXPRESS;Initial Catalog=Cpe5thyear;Integrated Security=True");
        private void Section1btn_Click(object sender, EventArgs e)
        {
            Sec1Update mm = new Sec1Update();
            this.Hide();

            mm.Show();
        }

        private void Section2btn_Click(object sender, EventArgs e)
        {
            Sec2Update mm = new Sec2Update();
            this.Hide();

            mm.Show();
        }

        private void Section3btn_Click(object sender, EventArgs e)
        {
            Sec3Update mm = new Sec3Update();
            this.Hide();

            mm.Show();
        }

        private void Section4btn_Click(object sender, EventArgs e)
        {
            Sec4Update mm = new Sec4Update();
            this.Hide();

            mm.Show();
        }

        private void Section5btn_Click(object sender, EventArgs e)
        {
            Sec5Update mm = new Sec5Update();
            this.Hide();

            mm.Show();
        }

        private void Section6btn_Click(object sender, EventArgs e)
        {
            Sec6Update mm = new Sec6Update();
            this.Hide();

            mm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            returnLogin();
        }

        private void returnLogin()
        {
            Login mm = new Login();
            this.Hide();

            mm.Show();
        }

        private void UpdateLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            returnLogin();
        }

        private void Section1blk_Click(object sender, EventArgs e)
        {

            SqlCommand truncate = new SqlCommand("TRUNCATE TABLE dbo.Sec1", conn);
            conn.Open();
            truncate.ExecuteNonQuery();
            conn.Close();

            var lines = System.IO.File.ReadAllLines(@"C:\Users\Andreian\Desktop\csv\5-1.csv");
            if (lines.Count() == 0) return;
            var columns = lines[0].Split(',');
            var table = new DataTable();
            foreach (var c in columns)
                table.Columns.Add(c);

            for (int i = 1; i < lines.Count() - 1; i++)
                table.Rows.Add(lines[i].Split(','));
            var bulkCopy = new SqlBulkCopy(conn);
            conn.Open();
            bulkCopy.DestinationTableName = "Sec1";
            bulkCopy.WriteToServer(table);
            conn.Close();
            MessageBox.Show("Bulk Update of Section 1 Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void Section2blk_Click(object sender, EventArgs e)
        {
            SqlCommand truncate = new SqlCommand("TRUNCATE TABLE dbo.Sec2", conn);
            conn.Open();
            truncate.ExecuteNonQuery();
            conn.Close();

            var lines = System.IO.File.ReadAllLines(@"C:\Users\Andreian\Desktop\csv\5-2.csv");
            if (lines.Count() == 0) return;
            var columns = lines[0].Split(',');
            var table = new DataTable();
            foreach (var c in columns)
                table.Columns.Add(c);

            for (int i = 1; i < lines.Count() - 1; i++)
                table.Rows.Add(lines[i].Split(','));
            var bulkCopy = new SqlBulkCopy(conn);
            conn.Open();
            bulkCopy.DestinationTableName = "Sec2";
            bulkCopy.WriteToServer(table);
            conn.Close();
            MessageBox.Show("Bulk Update of Section 2 Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Section3blk_Click(object sender, EventArgs e)
        {
            SqlCommand truncate = new SqlCommand("TRUNCATE TABLE dbo.Sec3", conn);
            conn.Open();
            truncate.ExecuteNonQuery();
            conn.Close();

            var lines = System.IO.File.ReadAllLines(@"C:\Users\Andreian\Desktop\csv\5-3.csv");
            if (lines.Count() == 0) return;
            var columns = lines[0].Split(',');
            var table = new DataTable();
            foreach (var c in columns)
                table.Columns.Add(c);

            for (int i = 1; i < lines.Count() - 1; i++)
                table.Rows.Add(lines[i].Split(','));
            var bulkCopy = new SqlBulkCopy(conn);
            conn.Open();
            bulkCopy.DestinationTableName = "Sec3";
            bulkCopy.WriteToServer(table);
            conn.Close();
            MessageBox.Show("Bulk Update of Section 3 Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Section4blk_Click(object sender, EventArgs e)
        {
            SqlCommand truncate = new SqlCommand("TRUNCATE TABLE dbo.Sec4", conn);
            conn.Open();
            truncate.ExecuteNonQuery();
            conn.Close();

            var lines = System.IO.File.ReadAllLines(@"C:\Users\Andreian\Desktop\csv\5-4.csv");
            if (lines.Count() == 0) return;
            var columns = lines[0].Split(',');
            var table = new DataTable();
            foreach (var c in columns)
                table.Columns.Add(c);

            for (int i = 1; i < lines.Count() - 1; i++)
                table.Rows.Add(lines[i].Split(','));
            var bulkCopy = new SqlBulkCopy(conn);
            conn.Open();
            bulkCopy.DestinationTableName = "Sec4";
            bulkCopy.WriteToServer(table);
            conn.Close();
            MessageBox.Show("Bulk Update of Section 4 Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Section5blk_Click(object sender, EventArgs e)
        {
            SqlCommand truncate = new SqlCommand("TRUNCATE TABLE dbo.Sec5", conn);
            conn.Open();
            truncate.ExecuteNonQuery();
            conn.Close();

            var lines = System.IO.File.ReadAllLines(@"C:\Users\Andreian\Desktop\csv\5-5.csv");
            if (lines.Count() == 0) return;
            var columns = lines[0].Split(',');
            var table = new DataTable();
            foreach (var c in columns)
                table.Columns.Add(c);

            for (int i = 1; i < lines.Count() - 1; i++)
                table.Rows.Add(lines[i].Split(','));
            var bulkCopy = new SqlBulkCopy(conn);
            conn.Open();
            bulkCopy.DestinationTableName = "Sec5";
            bulkCopy.WriteToServer(table);
            conn.Close();
            MessageBox.Show("Bulk Update of Section 5 Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Section6blk_Click(object sender, EventArgs e)
        {
            SqlCommand truncate = new SqlCommand("TRUNCATE TABLE dbo.Sec6", conn);
            conn.Open();
            truncate.ExecuteNonQuery();
            conn.Close();

            var lines = System.IO.File.ReadAllLines(@"C:\Users\Andreian\Desktop\csv\5-6.csv");
            if (lines.Count() == 0) return;
            var columns = lines[0].Split(',');
            var table = new DataTable();
            foreach (var c in columns)
                table.Columns.Add(c);

            for (int i = 1; i < lines.Count() - 1; i++)
                table.Rows.Add(lines[i].Split(','));
            var bulkCopy = new SqlBulkCopy(conn);
            conn.Open();
            bulkCopy.DestinationTableName = "Sec6";
            bulkCopy.WriteToServer(table);
            conn.Close();
            MessageBox.Show("Bulk Update of Section 6 Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void overAll_Click(object sender, EventArgs e)
        {
            SqlCommand truncate = new SqlCommand("TRUNCATE TABLE dbo.OverallSec", conn);
            conn.Open();
            truncate.ExecuteNonQuery();
            conn.Close();

            var lines = System.IO.File.ReadAllLines(@"C:\Users\Andreian\Desktop\csv\5thyearGlobal.csv");
            if (lines.Count() == 0) return;
            var columns = lines[0].Split(',');
            var table = new DataTable();
            foreach (var c in columns)
                table.Columns.Add(c);

            for (int i = 1; i < lines.Count() - 1; i++)
                table.Rows.Add(lines[i].Split(','));
            var bulkCopy = new SqlBulkCopy(conn);
            conn.Open();
            bulkCopy.DestinationTableName = "OverallSec";
            bulkCopy.WriteToServer(table);
            conn.Close();
            MessageBox.Show("Bulk Update of all Section Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
