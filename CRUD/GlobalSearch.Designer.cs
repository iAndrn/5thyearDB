namespace CRUD
{
    partial class GlobalSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StudentDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overallSecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cpe5thyearDataSetGlobalSearch = new CRUD.Cpe5thyearDataSetGlobalSearch();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.searchtextSecNum = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.label14 = new System.Windows.Forms.Label();
            this.overallSecTableAdapter = new CRUD.Cpe5thyearDataSetGlobalSearchTableAdapters.OverallSecTableAdapter();
            this.SectionNum = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchtextstudentNum = new System.Windows.Forms.TextBox();
            this.searchTextFname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchTextLname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overallSecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpe5thyearDataSetGlobalSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(363, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 40);
            this.label10.TabIndex = 106;
            this.label10.Text = "Class List";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(115, 770);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 22);
            this.label9.TabIndex = 105;
            this.label9.Text = "Contact Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(316, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 40);
            this.label4.TabIndex = 100;
            this.label4.Text = "Student Details";
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.StudentDataGridView.ColumnHeadersHeight = 30;
            this.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StudentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.studentNumDataGridViewTextBoxColumn,
            this.sectionNumDataGridViewTextBoxColumn,
            this.emailAddDataGridViewTextBoxColumn,
            this.contactNumDataGridViewTextBoxColumn});
            this.StudentDataGridView.DataSource = this.overallSecBindingSource;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentDataGridView.DefaultCellStyle = dataGridViewCellStyle17;
            this.StudentDataGridView.Location = new System.Drawing.Point(33, 169);
            this.StudentDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.StudentDataGridView.Name = "StudentDataGridView";
            this.StudentDataGridView.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.StudentDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StudentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentDataGridView.Size = new System.Drawing.Size(807, 215);
            this.StudentDataGridView.TabIndex = 93;
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
            // sectionNumDataGridViewTextBoxColumn
            // 
            this.sectionNumDataGridViewTextBoxColumn.DataPropertyName = "SectionNum";
            this.sectionNumDataGridViewTextBoxColumn.HeaderText = "SectionNum";
            this.sectionNumDataGridViewTextBoxColumn.Name = "sectionNumDataGridViewTextBoxColumn";
            this.sectionNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.sectionNumDataGridViewTextBoxColumn.Visible = false;
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
            // overallSecBindingSource
            // 
            this.overallSecBindingSource.DataMember = "OverallSec";
            this.overallSecBindingSource.DataSource = this.cpe5thyearDataSetGlobalSearch;
            // 
            // cpe5thyearDataSetGlobalSearch
            // 
            this.cpe5thyearDataSetGlobalSearch.DataSetName = "Cpe5thyearDataSetGlobalSearch";
            this.cpe5thyearDataSetGlobalSearch.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Orange;
            this.label11.Location = new System.Drawing.Point(292, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(288, 48);
            this.label11.TabIndex = 107;
            this.label11.Text = "Search Student";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(585, 120);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(86, 1);
            this.panel4.TabIndex = 120;
            // 
            // searchtextSecNum
            // 
            this.searchtextSecNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.searchtextSecNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchtextSecNum.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtextSecNum.ForeColor = System.Drawing.Color.White;
            this.searchtextSecNum.Location = new System.Drawing.Point(585, 87);
            this.searchtextSecNum.MaxLength = 1;
            this.searchtextSecNum.Name = "searchtextSecNum";
            this.searchtextSecNum.Size = new System.Drawing.Size(86, 30);
            this.searchtextSecNum.TabIndex = 100;
            this.searchtextSecNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchtextSecNum.TextChanged += new System.EventHandler(this.sectionNum_TextChanged);
            this.searchtextSecNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sectionNum_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(515, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 18);
            this.label13.TabIndex = 118;
            this.label13.Text = "Section";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(173, 670);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 22);
            this.label5.TabIndex = 136;
            this.label5.Text = "Contact:";
            // 
            // Mname
            // 
            this.Mname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.Mname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mname.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mname.ForeColor = System.Drawing.Color.White;
            this.Mname.Location = new System.Drawing.Point(272, 507);
            this.Mname.Name = "Mname";
            this.Mname.ReadOnly = true;
            this.Mname.Size = new System.Drawing.Size(301, 29);
            this.Mname.TabIndex = 135;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(136, 511);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 22);
            this.label12.TabIndex = 134;
            this.label12.Text = "Middle Name:";
            // 
            // contactNum
            // 
            this.contactNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.contactNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contactNum.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNum.ForeColor = System.Drawing.Color.White;
            this.contactNum.Location = new System.Drawing.Point(272, 666);
            this.contactNum.Name = "contactNum";
            this.contactNum.ReadOnly = true;
            this.contactNum.Size = new System.Drawing.Size(301, 29);
            this.contactNum.TabIndex = 133;
            // 
            // emailAdd
            // 
            this.emailAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.emailAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailAdd.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAdd.ForeColor = System.Drawing.Color.White;
            this.emailAdd.Location = new System.Drawing.Point(272, 624);
            this.emailAdd.Name = "emailAdd";
            this.emailAdd.ReadOnly = true;
            this.emailAdd.Size = new System.Drawing.Size(370, 29);
            this.emailAdd.TabIndex = 132;
            // 
            // studentNum
            // 
            this.studentNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.studentNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentNum.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNum.ForeColor = System.Drawing.Color.White;
            this.studentNum.Location = new System.Drawing.Point(272, 582);
            this.studentNum.Name = "studentNum";
            this.studentNum.ReadOnly = true;
            this.studentNum.Size = new System.Drawing.Size(301, 29);
            this.studentNum.TabIndex = 131;
            // 
            // Lname
            // 
            this.Lname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.Lname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lname.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname.ForeColor = System.Drawing.Color.White;
            this.Lname.Location = new System.Drawing.Point(272, 465);
            this.Lname.Name = "Lname";
            this.Lname.ReadOnly = true;
            this.Lname.Size = new System.Drawing.Size(301, 29);
            this.Lname.TabIndex = 130;
            // 
            // Fname
            // 
            this.Fname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.Fname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Fname.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname.ForeColor = System.Drawing.Color.White;
            this.Fname.Location = new System.Drawing.Point(272, 423);
            this.Fname.Name = "Fname";
            this.Fname.ReadOnly = true;
            this.Fname.Size = new System.Drawing.Size(301, 29);
            this.Fname.TabIndex = 129;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(135, 628);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 22);
            this.label8.TabIndex = 128;
            this.label8.Text = "Email Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(108, 586);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 22);
            this.label7.TabIndex = 127;
            this.label7.Text = "Student Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(161, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 22);
            this.label6.TabIndex = 126;
            this.label6.Text = "Last Name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(165, 427);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 22);
            this.label14.TabIndex = 125;
            this.label14.Text = "First Name:";
            // 
            // overallSecTableAdapter
            // 
            this.overallSecTableAdapter.ClearBeforeFill = true;
            // 
            // SectionNum
            // 
            this.SectionNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.SectionNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SectionNum.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionNum.ForeColor = System.Drawing.Color.White;
            this.SectionNum.Location = new System.Drawing.Point(273, 544);
            this.SectionNum.Name = "SectionNum";
            this.SectionNum.ReadOnly = true;
            this.SectionNum.Size = new System.Drawing.Size(301, 29);
            this.SectionNum.TabIndex = 138;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(137, 548);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 22);
            this.label15.TabIndex = 137;
            this.label15.Text = "Class Section:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(587, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 1);
            this.panel3.TabIndex = 146;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(101, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 1);
            this.panel1.TabIndex = 145;
            // 
            // searchtextstudentNum
            // 
            this.searchtextstudentNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.searchtextstudentNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchtextstudentNum.Font = new System.Drawing.Font("Arial", 14.25F);
            this.searchtextstudentNum.ForeColor = System.Drawing.Color.White;
            this.searchtextstudentNum.Location = new System.Drawing.Point(588, 56);
            this.searchtextstudentNum.Name = "searchtextstudentNum";
            this.searchtextstudentNum.Size = new System.Drawing.Size(168, 22);
            this.searchtextstudentNum.TabIndex = 144;
            this.searchtextstudentNum.TextChanged += new System.EventHandler(this.searchtextstudentNum_TextChanged);
            // 
            // searchTextFname
            // 
            this.searchTextFname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.searchTextFname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextFname.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextFname.ForeColor = System.Drawing.Color.White;
            this.searchTextFname.Location = new System.Drawing.Point(101, 54);
            this.searchTextFname.Name = "searchTextFname";
            this.searchTextFname.Size = new System.Drawing.Size(255, 22);
            this.searchTextFname.TabIndex = 142;
            this.searchTextFname.TextChanged += new System.EventHandler(this.searchTextFname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(515, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 141;
            this.label3.Text = "Student #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 139;
            this.label1.Text = "First Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(102, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 1);
            this.panel2.TabIndex = 90;
            // 
            // searchTextLname
            // 
            this.searchTextLname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.searchTextLname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextLname.Font = new System.Drawing.Font("Arial", 14.25F);
            this.searchTextLname.ForeColor = System.Drawing.Color.White;
            this.searchTextLname.Location = new System.Drawing.Point(102, 96);
            this.searchTextLname.Name = "searchTextLname";
            this.searchTextLname.Size = new System.Drawing.Size(255, 22);
            this.searchTextLname.TabIndex = 89;
            this.searchTextLname.TextChanged += new System.EventHandler(this.searchTextLname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 88;
            this.label2.Text = "Last Name";
            // 
            // GlobalSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(860, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.searchTextLname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchtextstudentNum);
            this.Controls.Add(this.searchTextFname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SectionNum);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label5);
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
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.searchtextSecNum);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StudentDataGridView);
            this.MaximizeBox = false;
            this.Name = "GlobalSearch";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Global Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GlobalSearch_FormClosing);
            this.Load += new System.EventHandler(this.GlobalDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overallSecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpe5thyearDataSetGlobalSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView StudentDataGridView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox searchtextSecNum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.Label label14;
        private Cpe5thyearDataSetGlobalSearch cpe5thyearDataSetGlobalSearch;
        private System.Windows.Forms.BindingSource overallSecBindingSource;
        private Cpe5thyearDataSetGlobalSearchTableAdapters.OverallSecTableAdapter overallSecTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox SectionNum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchtextstudentNum;
        private System.Windows.Forms.TextBox searchTextFname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox searchTextLname;
        private System.Windows.Forms.Label label2;
    }
}