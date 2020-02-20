namespace CRUD
{
    partial class Sec3Update
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchtextstudentNum = new System.Windows.Forms.TextBox();
            this.searchTextLname = new System.Windows.Forms.TextBox();
            this.searchTextFname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.StudentDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sec3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cpe5thyearDataSetSec3 = new CRUD.Cpe5thyearDataSetSec3();
            this.sec3TableAdapter = new CRUD.Cpe5thyearDataSetSec3TableAdapters.Sec3TableAdapter();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Mname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.contactNum = new System.Windows.Forms.TextBox();
            this.emailAdd = new System.Windows.Forms.TextBox();
            this.studentNum = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sec3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpe5thyearDataSetSec3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(217, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 48);
            this.label1.TabIndex = 40;
            this.label1.Text = "Update Student";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(517, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 1);
            this.panel3.TabIndex = 66;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(98, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 1);
            this.panel2.TabIndex = 65;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(98, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 1);
            this.panel1.TabIndex = 64;
            // 
            // searchtextstudentNum
            // 
            this.searchtextstudentNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.searchtextstudentNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchtextstudentNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.searchtextstudentNum.Font = new System.Drawing.Font("Arial", 14.25F);
            this.searchtextstudentNum.ForeColor = System.Drawing.Color.White;
            this.searchtextstudentNum.Location = new System.Drawing.Point(518, 59);
            this.searchtextstudentNum.Name = "searchtextstudentNum";
            this.searchtextstudentNum.Size = new System.Drawing.Size(168, 22);
            this.searchtextstudentNum.TabIndex = 63;
            this.searchtextstudentNum.TextChanged += new System.EventHandler(this.searchtextstudentNum_TextChanged);
            // 
            // searchTextLname
            // 
            this.searchTextLname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.searchTextLname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextLname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.searchTextLname.Font = new System.Drawing.Font("Arial", 14.25F);
            this.searchTextLname.ForeColor = System.Drawing.Color.White;
            this.searchTextLname.Location = new System.Drawing.Point(98, 99);
            this.searchTextLname.Name = "searchTextLname";
            this.searchTextLname.Size = new System.Drawing.Size(255, 22);
            this.searchTextLname.TabIndex = 62;
            this.searchTextLname.TextChanged += new System.EventHandler(this.searchTextLname_TextChanged);
            // 
            // searchTextFname
            // 
            this.searchTextFname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.searchTextFname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextFname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.searchTextFname.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextFname.ForeColor = System.Drawing.Color.White;
            this.searchTextFname.Location = new System.Drawing.Point(98, 54);
            this.searchTextFname.Name = "searchTextFname";
            this.searchTextFname.Size = new System.Drawing.Size(255, 22);
            this.searchTextFname.TabIndex = 61;
            this.searchTextFname.TextChanged += new System.EventHandler(this.searchTextFname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(445, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "Student #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 58;
            this.label4.Text = "First Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(293, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 40);
            this.label10.TabIndex = 68;
            this.label10.Text = "Class List";
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
            this.StudentDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
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
            this.middleNameDataGridViewTextBoxColumn,
            this.studentNumDataGridViewTextBoxColumn,
            this.emailAddDataGridViewTextBoxColumn,
            this.contactNumDataGridViewTextBoxColumn});
            this.StudentDataGridView.DataSource = this.sec3BindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.StudentDataGridView.Location = new System.Drawing.Point(45, 190);
            this.StudentDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.StudentDataGridView.Name = "StudentDataGridView";
            this.StudentDataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.StudentDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StudentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentDataGridView.Size = new System.Drawing.Size(645, 158);
            this.StudentDataGridView.TabIndex = 67;
            this.StudentDataGridView.VirtualMode = true;
            this.StudentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDataGridView_CellClick);
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
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.middleNameDataGridViewTextBoxColumn.Visible = false;
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
            // sec3BindingSource
            // 
            this.sec3BindingSource.DataMember = "Sec3";
            this.sec3BindingSource.DataSource = this.cpe5thyearDataSetSec3;
            // 
            // cpe5thyearDataSetSec3
            // 
            this.cpe5thyearDataSetSec3.DataSetName = "Cpe5thyearDataSetSec3";
            this.cpe5thyearDataSetSec3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sec3TableAdapter
            // 
            this.sec3TableAdapter.ClearBeforeFill = true;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateBtn.Font = new System.Drawing.Font("Montserrat Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(225, 652);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(133, 36);
            this.updateBtn.TabIndex = 87;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(111, 611);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 22);
            this.label9.TabIndex = 86;
            this.label9.Text = "Contact:";
            // 
            // Mname
            // 
            this.Mname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.Mname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Mname.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mname.ForeColor = System.Drawing.Color.White;
            this.Mname.Location = new System.Drawing.Point(205, 481);
            this.Mname.Name = "Mname";
            this.Mname.Size = new System.Drawing.Size(301, 29);
            this.Mname.TabIndex = 85;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(69, 485);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 22);
            this.label12.TabIndex = 84;
            this.label12.Text = "Middle Name:";
            // 
            // contactNum
            // 
            this.contactNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.contactNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contactNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.contactNum.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNum.ForeColor = System.Drawing.Color.White;
            this.contactNum.Location = new System.Drawing.Point(205, 607);
            this.contactNum.MaxLength = 11;
            this.contactNum.Name = "contactNum";
            this.contactNum.Size = new System.Drawing.Size(301, 29);
            this.contactNum.TabIndex = 83;
            this.contactNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contactNum_KeyPress);
            // 
            // emailAdd
            // 
            this.emailAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.emailAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailAdd.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAdd.ForeColor = System.Drawing.Color.White;
            this.emailAdd.Location = new System.Drawing.Point(205, 565);
            this.emailAdd.Name = "emailAdd";
            this.emailAdd.Size = new System.Drawing.Size(370, 29);
            this.emailAdd.TabIndex = 82;
            // 
            // studentNum
            // 
            this.studentNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.studentNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.studentNum.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNum.ForeColor = System.Drawing.Color.White;
            this.studentNum.Location = new System.Drawing.Point(205, 523);
            this.studentNum.Name = "studentNum";
            this.studentNum.Size = new System.Drawing.Size(301, 29);
            this.studentNum.TabIndex = 81;
            // 
            // Lname
            // 
            this.Lname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.Lname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Lname.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname.ForeColor = System.Drawing.Color.White;
            this.Lname.Location = new System.Drawing.Point(205, 439);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(301, 29);
            this.Lname.TabIndex = 80;
            // 
            // Fname
            // 
            this.Fname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.Fname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Fname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Fname.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname.ForeColor = System.Drawing.Color.White;
            this.Fname.Location = new System.Drawing.Point(205, 397);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(301, 29);
            this.Fname.TabIndex = 79;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(68, 569);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 22);
            this.label8.TabIndex = 78;
            this.label8.Text = "Email Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(41, 527);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 22);
            this.label7.TabIndex = 77;
            this.label7.Text = "Student Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(94, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 22);
            this.label6.TabIndex = 76;
            this.label6.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(98, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 22);
            this.label5.TabIndex = 75;
            this.label5.Text = "First Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(247, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(242, 40);
            this.label11.TabIndex = 74;
            this.label11.Text = "Student Details";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBtn.Font = new System.Drawing.Font("Montserrat Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(382, 652);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(133, 36);
            this.deleteBtn.TabIndex = 132;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // Sec3Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(728, 700);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Mname);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.contactNum);
            this.Controls.Add(this.emailAdd);
            this.Controls.Add(this.studentNum);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.StudentDataGridView);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchtextstudentNum);
            this.Controls.Add(this.searchTextLname);
            this.Controls.Add(this.searchTextFname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Sec3Update";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Section 3 Update";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sec3Update_FormClosing);
            this.Load += new System.EventHandler(this.Sec3Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sec3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpe5thyearDataSetSec3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchtextstudentNum;
        private System.Windows.Forms.TextBox searchTextLname;
        private System.Windows.Forms.TextBox searchTextFname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView StudentDataGridView;
        private Cpe5thyearDataSetSec3 cpe5thyearDataSetSec3;
        private System.Windows.Forms.BindingSource sec3BindingSource;
        private Cpe5thyearDataSetSec3TableAdapters.Sec3TableAdapter sec3TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Mname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox contactNum;
        private System.Windows.Forms.TextBox emailAdd;
        private System.Windows.Forms.TextBox studentNum;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button deleteBtn;
    }
}