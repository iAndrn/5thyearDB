﻿namespace CRUD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StudentDataGridView = new System.Windows.Forms.DataGridView();
            
            this.sec1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchTextFname = new System.Windows.Forms.TextBox();
            this.searchTextLname = new System.Windows.Forms.TextBox();
            this.searchtextstudentNum = new System.Windows.Forms.TextBox();
            this.contactNum = new System.Windows.Forms.TextBox();
            this.emailAdd = new System.Windows.Forms.TextBox();
            this.studentNum = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Mname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cpe5thyearDataSetSec11 = new CRUD.Cpe5thyearDataSetSec1();
            this.sec1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sec1TableAdapter1 = new CRUD.Cpe5thyearDataSetSec1TableAdapters.Sec1TableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).BeginInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.sec1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpe5thyearDataSetSec11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sec1BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentDataGridView
            // 
            this.StudentDataGridView.AccessibleName = "StudentDataGridView";
            this.StudentDataGridView.AllowUserToResizeColumns = false;
            this.StudentDataGridView.AllowUserToResizeRows = false;
            this.StudentDataGridView.AutoGenerateColumns = false;
            this.StudentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StudentDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.StudentDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentDataGridView.ColumnHeadersHeight = 30;
            this.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StudentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn7,
            this.studentNumDataGridViewTextBoxColumn,
            this.emailAddDataGridViewTextBoxColumn,
            this.contactNumDataGridViewTextBoxColumn});
            this.StudentDataGridView.DataSource = this.sec1BindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.StudentDataGridView.Location = new System.Drawing.Point(36, 197);
            this.StudentDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.StudentDataGridView.Name = "StudentDataGridView";
            this.StudentDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.StudentDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StudentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentDataGridView.Size = new System.Drawing.Size(645, 215);
            this.StudentDataGridView.TabIndex = 0;
            this.StudentDataGridView.VirtualMode = true;
            this.StudentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDataGridView_CellClick);
            // 
            // sec1BindingSource1
            // 
            
            // 
            // sec1BindingSource
            // 
            this.sec1BindingSource.DataMember = "Sec1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Student #";
            // 
            // searchTextFname
            // 
            this.searchTextFname.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextFname.Location = new System.Drawing.Point(274, 42);
            this.searchTextFname.Name = "searchTextFname";
            this.searchTextFname.Size = new System.Drawing.Size(168, 29);
            this.searchTextFname.TabIndex = 8;
            this.searchTextFname.TextChanged += new System.EventHandler(this.searchTextFname_TextChanged);
            this.searchTextFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextFname_KeyPress);
            // 
            // searchTextLname
            // 
            this.searchTextLname.Font = new System.Drawing.Font("Arial", 14.25F);
            this.searchTextLname.Location = new System.Drawing.Point(274, 82);
            this.searchTextLname.Name = "searchTextLname";
            this.searchTextLname.Size = new System.Drawing.Size(168, 29);
            this.searchTextLname.TabIndex = 9;
            this.searchTextLname.TextChanged += new System.EventHandler(this.searchTextLname_TextChanged);
            // 
            // searchtextstudentNum
            // 
            this.searchtextstudentNum.Font = new System.Drawing.Font("Arial", 14.25F);
            this.searchtextstudentNum.Location = new System.Drawing.Point(274, 125);
            this.searchtextstudentNum.Name = "searchtextstudentNum";
            this.searchtextstudentNum.Size = new System.Drawing.Size(168, 29);
            this.searchtextstudentNum.TabIndex = 10;
            this.searchtextstudentNum.TextChanged += new System.EventHandler(this.searchtextstudentNum_TextChanged);
            // 
            // contactNum
            // 
            this.contactNum.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNum.Location = new System.Drawing.Point(201, 684);
            this.contactNum.Name = "contactNum";
            this.contactNum.ReadOnly = true;
            this.contactNum.Size = new System.Drawing.Size(301, 31);
            this.contactNum.TabIndex = 43;
            // 
            // emailAdd
            // 
            this.emailAdd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAdd.Location = new System.Drawing.Point(201, 642);
            this.emailAdd.Name = "emailAdd";
            this.emailAdd.ReadOnly = true;
            this.emailAdd.Size = new System.Drawing.Size(301, 31);
            this.emailAdd.TabIndex = 42;
            // 
            // studentNum
            // 
            this.studentNum.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNum.Location = new System.Drawing.Point(201, 600);
            this.studentNum.Name = "studentNum";
            this.studentNum.ReadOnly = true;
            this.studentNum.Size = new System.Drawing.Size(301, 31);
            this.studentNum.TabIndex = 41;
            // 
            // Lname
            // 
            this.Lname.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname.Location = new System.Drawing.Point(201, 516);
            this.Lname.Name = "Lname";
            this.Lname.ReadOnly = true;
            this.Lname.Size = new System.Drawing.Size(301, 31);
            this.Lname.TabIndex = 40;
            // 
            // Fname
            // 
            this.Fname.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname.Location = new System.Drawing.Point(201, 474);
            this.Fname.Name = "Fname";
            this.Fname.ReadOnly = true;
            this.Fname.Size = new System.Drawing.Size(301, 31);
            this.Fname.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(302, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 36);
            this.label11.TabIndex = 38;
            this.label11.Text = "Search";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(288, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 36);
            this.label10.TabIndex = 37;
            this.label10.Text = "Class List";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 693);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 22);
            this.label9.TabIndex = 36;
            this.label9.Text = "Contact Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 651);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 22);
            this.label8.TabIndex = 35;
            this.label8.Text = "Email Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 609);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 22);
            this.label7.TabIndex = 34;
            this.label7.Text = "Student Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 525);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 22);
            this.label6.TabIndex = 33;
            this.label6.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 22);
            this.label5.TabIndex = 32;
            this.label5.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(247, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 36);
            this.label4.TabIndex = 31;
            this.label4.Text = "Student Details";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Mname
            // 
            this.Mname.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mname.Location = new System.Drawing.Point(201, 558);
            this.Mname.Name = "Mname";
            this.Mname.ReadOnly = true;
            this.Mname.Size = new System.Drawing.Size(301, 31);
            this.Mname.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(65, 567);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 22);
            this.label12.TabIndex = 44;
            this.label12.Text = "Middle Name:";
            // 
            // cpe5thyearDataSetSec11
            // 
            this.cpe5thyearDataSetSec11.DataSetName = "Cpe5thyearDataSetSec1";
            this.cpe5thyearDataSetSec11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sec1BindingSource2
            // 
            this.sec1BindingSource2.DataMember = "Sec1";
            this.sec1BindingSource2.DataSource = this.cpe5thyearDataSetSec11;
            // 
            // sec1TableAdapter1
            // 
            this.sec1TableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MiddleName";
            this.dataGridViewTextBoxColumn7.HeaderText = "MiddleName";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // studentNumDataGridViewTextBoxColumn
            // 
            this.studentNumDataGridViewTextBoxColumn.DataPropertyName = "StudentNum";
            this.studentNumDataGridViewTextBoxColumn.HeaderText = "Student Number";
            this.studentNumDataGridViewTextBoxColumn.Name = "studentNumDataGridViewTextBoxColumn";
            this.studentNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailAddDataGridViewTextBoxColumn
            // 
            this.emailAddDataGridViewTextBoxColumn.DataPropertyName = "emailAdd";
            this.emailAddDataGridViewTextBoxColumn.HeaderText = "emailAdd";
            this.emailAddDataGridViewTextBoxColumn.Name = "emailAddDataGridViewTextBoxColumn";
            this.emailAddDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailAddDataGridViewTextBoxColumn.Visible = false;
            // 
            // contactNumDataGridViewTextBoxColumn
            // 
            this.contactNumDataGridViewTextBoxColumn.DataPropertyName = "contactNum";
            this.contactNumDataGridViewTextBoxColumn.HeaderText = "contactNum";
            this.contactNumDataGridViewTextBoxColumn.Name = "contactNumDataGridViewTextBoxColumn";
            this.contactNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactNumDataGridViewTextBoxColumn.Visible = false;
            // 
            // Sec1
            // 
            this.AccessibleName = "StudentDataGridView";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 744);
            this.Controls.Add(this.Mname);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.contactNum);
            this.Controls.Add(this.emailAdd);
            this.Controls.Add(this.studentNum);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchtextstudentNum);
            this.Controls.Add(this.searchTextLname);
            this.Controls.Add(this.searchTextFname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.cpe5thyearDataSetSec11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sec1BindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchTextFname;
        private System.Windows.Forms.TextBox searchTextLname;
        private System.Windows.Forms.TextBox searchtextstudentNum;
        private System.Windows.Forms.TextBox contactNum;
        private System.Windows.Forms.TextBox emailAdd;
        private System.Windows.Forms.TextBox studentNum;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource sec1BindingSource;
        
        private System.Windows.Forms.TextBox Mname;
        private System.Windows.Forms.Label label12;
        
        private Cpe5thyearDataSetSec1 cpe5thyearDataSetSec11;
        private System.Windows.Forms.BindingSource sec1BindingSource2;
        private Cpe5thyearDataSetSec1TableAdapters.Sec1TableAdapter sec1TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumDataGridViewTextBoxColumn;
    }
}


