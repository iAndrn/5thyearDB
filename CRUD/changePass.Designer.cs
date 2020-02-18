namespace CRUD
{
    partial class changePass
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.oldPass = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.newPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.button1.Location = new System.Drawing.Point(50, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(237, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(42, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 48);
            this.label2.TabIndex = 14;
            this.label2.Text = "Change Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(102, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 1);
            this.panel1.TabIndex = 16;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.DarkGray;
            this.username.Location = new System.Drawing.Point(102, 91);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(214, 23);
            this.username.TabIndex = 15;
            this.username.Text = "Username";
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username.Enter += new System.EventHandler(this.username_Enter);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(102, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 1);
            this.panel2.TabIndex = 18;
            // 
            // oldPass
            // 
            this.oldPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.oldPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oldPass.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPass.ForeColor = System.Drawing.Color.DarkGray;
            this.oldPass.Location = new System.Drawing.Point(102, 162);
            this.oldPass.Name = "oldPass";
            this.oldPass.Size = new System.Drawing.Size(214, 23);
            this.oldPass.TabIndex = 17;
            this.oldPass.Text = "Current Password";
            this.oldPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.oldPass.Enter += new System.EventHandler(this.oldPass_Enter);
            this.oldPass.Leave += new System.EventHandler(this.oldPass_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(102, 258);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 1);
            this.panel3.TabIndex = 20;
            // 
            // newPass
            // 
            this.newPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.newPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPass.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPass.ForeColor = System.Drawing.Color.DarkGray;
            this.newPass.Location = new System.Drawing.Point(102, 233);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(214, 23);
            this.newPass.TabIndex = 19;
            this.newPass.Text = "New Password";
            this.newPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newPass.Enter += new System.EventHandler(this.newPass_Enter);
            this.newPass.Leave += new System.EventHandler(this.newPass_Leave);
            // 
            // changePass
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(419, 384);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.oldPass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "changePass";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.changePass_FormClosing);
            this.Load += new System.EventHandler(this.changePass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox oldPass;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox newPass;
    }
}