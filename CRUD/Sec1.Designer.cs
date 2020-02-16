namespace CRUD
{
    partial class Sec1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StudentDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sec1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cpe5thyearDataSet3 = new CRUD.Cpe5thyearDataSet3();
            this.Fname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sec1TableAdapter = new CRUD.Cpe5thyearDataSet3TableAdapters.Sec1TableAdapter();
           
            this.cpe5thyearDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchTextFname = new System.Windows.Forms.TextBox();
            this.searchTextLname = new System.Windows.Forms.TextBox();
            this.searchtextstudentNum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sec1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpe5thyearDataSet3)).BeginInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.cpe5thyearDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentDataGridView
            // 
            this.StudentDataGridView.AccessibleName = "StudentDataGridView";
            this.StudentDataGridView.AllowUserToResizeColumns = false;
            this.StudentDataGridView.AllowUserToResizeRows = false;
            this.StudentDataGridView.AutoGenerateColumns = false;
            this.StudentDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StudentDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.StudentDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.StudentDataGridView.ColumnHeadersHeight = 30;
            this.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StudentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.studentNumDataGridViewTextBoxColumn});
            this.StudentDataGridView.DataSource = this.sec1BindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.StudentDataGridView.Location = new System.Drawing.Point(39, 189);
            this.StudentDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.StudentDataGridView.Name = "StudentDataGridView";
            this.StudentDataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.StudentDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StudentDataGridView.Size = new System.Drawing.Size(645, 215);
            this.StudentDataGridView.TabIndex = 0;
            this.StudentDataGridView.VirtualMode = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 190;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 190;
            // 
            // studentNumDataGridViewTextBoxColumn
            // 
            this.studentNumDataGridViewTextBoxColumn.DataPropertyName = "StudentNum";
            this.studentNumDataGridViewTextBoxColumn.HeaderText = "StudentNum";
            this.studentNumDataGridViewTextBoxColumn.Name = "studentNumDataGridViewTextBoxColumn";
            this.studentNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentNumDataGridViewTextBoxColumn.Width = 180;
            // 
            // sec1BindingSource
            // 
            this.sec1BindingSource.DataMember = "Sec1";
            this.sec1BindingSource.DataSource = this.cpe5thyearDataSet3;
            // 
            // cpe5thyearDataSet3
            // 
            this.cpe5thyearDataSet3.DataSetName = "Cpe5thyearDataSet3";
            this.cpe5thyearDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(450, 45);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(167, 20);
            this.Fname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // Lname
            // 
            this.Lname.Location = new System.Drawing.Point(450, 78);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(167, 20);
            this.Lname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // StudentNum
            // 
            this.StudentNum.Location = new System.Drawing.Point(450, 111);
            this.StudentNum.Name = "StudentNum";
            this.StudentNum.Size = new System.Drawing.Size(167, 20);
            this.StudentNum.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Student #";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 19);
            this.button1.TabIndex = 7;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sec1TableAdapter
            // 
            this.sec1TableAdapter.ClearBeforeFill = true;
            // 
            
            // searchTextFname
            // 
            this.searchTextFname.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextFname.Location = new System.Drawing.Point(97, 39);
            this.searchTextFname.Name = "searchTextFname";
            this.searchTextFname.Size = new System.Drawing.Size(168, 29);
            this.searchTextFname.TabIndex = 8;
            this.searchTextFname.TextChanged += new System.EventHandler(this.searchTextFname_TextChanged);
            // 
            // searchTextLname
            // 
            this.searchTextLname.Font = new System.Drawing.Font("Arial", 14.25F);
            this.searchTextLname.Location = new System.Drawing.Point(97, 78);
            this.searchTextLname.Name = "searchTextLname";
            this.searchTextLname.Size = new System.Drawing.Size(168, 29);
            this.searchTextLname.TabIndex = 9;
            this.searchTextLname.TextChanged += new System.EventHandler(this.searchTextLname_TextChanged);
            // 
            // searchtextstudentNum
            // 
            this.searchtextstudentNum.Font = new System.Drawing.Font("Arial", 14.25F);
            this.searchtextstudentNum.Location = new System.Drawing.Point(97, 121);
            this.searchtextstudentNum.Name = "searchtextstudentNum";
            this.searchtextstudentNum.Size = new System.Drawing.Size(168, 29);
            this.searchtextstudentNum.TabIndex = 10;
            this.searchtextstudentNum.TextChanged += new System.EventHandler(this.searchtextstudentNum_TextChanged);
            // 
            // Sec1
            // 
            this.AccessibleName = "StudentDataGridView";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 440);
            this.Controls.Add(this.searchtextstudentNum);
            this.Controls.Add(this.searchTextLname);
            this.Controls.Add(this.searchTextFname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StudentNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.StudentDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Sec1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Section 1 Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sec1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sec1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpe5thyearDataSet3)).EndInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.cpe5thyearDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentDataGridView;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StudentNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private Cpe5thyearDataSet3 cpe5thyearDataSet3;
        private System.Windows.Forms.BindingSource sec1BindingSource;
        private Cpe5thyearDataSet3TableAdapters.Sec1TableAdapter sec1TableAdapter;
        private System.Windows.Forms.BindingSource cpe5thyearDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox searchTextFname;
        private System.Windows.Forms.TextBox searchTextLname;
        private System.Windows.Forms.TextBox searchtextstudentNum;
    }
}

