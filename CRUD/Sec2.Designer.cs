﻿namespace CRUD
{
    partial class Sec2
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
            this.searchtextstudentNum = new System.Windows.Forms.TextBox();
            this.searchTextLname = new System.Windows.Forms.TextBox();
            this.searchTextFname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sec2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cpe5thyearDataSetSec2 = new CRUD.Cpe5thyearDataSetSec2();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.TextBox();
            this.emailAdd = new System.Windows.Forms.TextBox();
            this.studentNum = new System.Windows.Forms.TextBox();
            this.contactNum = new System.Windows.Forms.TextBox();
            this.Mname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.sec2TableAdapter = new CRUD.Cpe5thyearDataSetSec2TableAdapters.Sec2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sec2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpe5thyearDataSetSec2)).BeginInit();
            this.SuspendLayout();
            // 
            // searchtextstudentNum
            // 
            this.searchtextstudentNum.Font = new System.Drawing.Font("Arial", 14.25F);
            this.searchtextstudentNum.Location = new System.Drawing.Point(274, 125);
            this.searchtextstudentNum.Name = "searchtextstudentNum";
            this.searchtextstudentNum.Size = new System.Drawing.Size(168, 29);
            this.searchtextstudentNum.TabIndex = 17;
            this.searchtextstudentNum.TextChanged += new System.EventHandler(this.searchtextstudentNum_TextChanged);
            // 
            // searchTextLname
            // 
            this.searchTextLname.Font = new System.Drawing.Font("Arial", 14.25F);
            this.searchTextLname.Location = new System.Drawing.Point(274, 82);
            this.searchTextLname.Name = "searchTextLname";
            this.searchTextLname.Size = new System.Drawing.Size(168, 29);
            this.searchTextLname.TabIndex = 16;
            this.searchTextLname.TextChanged += new System.EventHandler(this.searchTextLname_TextChanged);
            // 
            // searchTextFname
            // 
            this.searchTextFname.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextFname.Location = new System.Drawing.Point(274, 42);
            this.searchTextFname.Name = "searchTextFname";
            this.searchTextFname.Size = new System.Drawing.Size(168, 29);
            this.searchTextFname.TabIndex = 15;
            this.searchTextFname.TextChanged += new System.EventHandler(this.searchTextFname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Student #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "First Name";
            // 
            // StudentDataGridView
            // 
            this.StudentDataGridView.AccessibleName = "StudentDataGridView";
            this.StudentDataGridView.AllowUserToDeleteRows = false;
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.middleNameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.StudentDataGridView.DataSource = this.sec2BindingSource;
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
            this.StudentDataGridView.TabIndex = 11;
            this.StudentDataGridView.VirtualMode = true;
            this.StudentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "Middle Name";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.middleNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StudentNum";
            this.dataGridViewTextBoxColumn4.HeaderText = "Student Number";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "emailAdd";
            this.dataGridViewTextBoxColumn5.HeaderText = "emailAdd";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "contactNum";
            this.dataGridViewTextBoxColumn6.HeaderText = "contactNum";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // sec2BindingSource
            // 
            this.sec2BindingSource.DataMember = "Sec2";
            this.sec2BindingSource.DataSource = this.cpe5thyearDataSetSec2;
            // 
            // cpe5thyearDataSetSec2
            // 
            this.cpe5thyearDataSetSec2.DataSetName = "Cpe5thyearDataSetSec2";
            this.cpe5thyearDataSetSec2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(247, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 36);
            this.label4.TabIndex = 18;
            this.label4.Text = "Student Details";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "First Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(94, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "Last Name:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 589);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 22);
            this.label7.TabIndex = 21;
            this.label7.Text = "Student Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 631);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 22);
            this.label8.TabIndex = 22;
            this.label8.Text = "Email Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 673);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 22);
            this.label9.TabIndex = 23;
            this.label9.Text = "Contact Number:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(288, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 36);
            this.label10.TabIndex = 24;
            this.label10.Text = "Class List";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(302, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 36);
            this.label11.TabIndex = 25;
            this.label11.Text = "Search";
            // 
            // Fname
            // 
            this.Fname.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname.Location = new System.Drawing.Point(205, 454);
            this.Fname.Name = "Fname";
            this.Fname.ReadOnly = true;
            this.Fname.Size = new System.Drawing.Size(301, 31);
            this.Fname.TabIndex = 26;
            // 
            // Lname
            // 
            this.Lname.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname.Location = new System.Drawing.Point(205, 496);
            this.Lname.Name = "Lname";
            this.Lname.ReadOnly = true;
            this.Lname.Size = new System.Drawing.Size(301, 31);
            this.Lname.TabIndex = 27;
            // 
            // emailAdd
            // 
            this.emailAdd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAdd.Location = new System.Drawing.Point(205, 622);
            this.emailAdd.Name = "emailAdd";
            this.emailAdd.ReadOnly = true;
            this.emailAdd.Size = new System.Drawing.Size(301, 31);
            this.emailAdd.TabIndex = 29;
            // 
            // studentNum
            // 
            this.studentNum.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNum.Location = new System.Drawing.Point(205, 580);
            this.studentNum.Name = "studentNum";
            this.studentNum.ReadOnly = true;
            this.studentNum.Size = new System.Drawing.Size(301, 31);
            this.studentNum.TabIndex = 28;
            // 
            // contactNum
            // 
            this.contactNum.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNum.Location = new System.Drawing.Point(205, 664);
            this.contactNum.Name = "contactNum";
            this.contactNum.ReadOnly = true;
            this.contactNum.Size = new System.Drawing.Size(301, 31);
            this.contactNum.TabIndex = 30;
            // 
            // Mname
            // 
            this.Mname.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mname.Location = new System.Drawing.Point(205, 538);
            this.Mname.Name = "Mname";
            this.Mname.ReadOnly = true;
            this.Mname.Size = new System.Drawing.Size(301, 31);
            this.Mname.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(69, 547);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 22);
            this.label12.TabIndex = 31;
            this.label12.Text = "Middle Name:";
            // 
            // sec2TableAdapter
            // 
            this.sec2TableAdapter.ClearBeforeFill = true;
            // 
            // Sec2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 700);
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
            this.Name = "Sec2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Section 2 Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sec2_FormClosing);
            this.Load += new System.EventHandler(this.Sec2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sec2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpe5thyearDataSetSec2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchtextstudentNum;
        private System.Windows.Forms.TextBox searchTextLname;
        private System.Windows.Forms.TextBox searchTextFname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView StudentDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox emailAdd;
        private System.Windows.Forms.TextBox studentNum;
        private System.Windows.Forms.TextBox contactNum;

        private System.Windows.Forms.TextBox Mname;
        private System.Windows.Forms.Label label12;
        private Cpe5thyearDataSetSec2 cpe5thyearDataSetSec2;
        private System.Windows.Forms.BindingSource sec2BindingSource;
        private Cpe5thyearDataSetSec2TableAdapters.Sec2TableAdapter sec2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}