namespace Company_DB
{
    partial class FrmAddUser
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
            txtEmail = new TextBox();
            label1 = new Label();
            txtFirstname = new TextBox();
            txtLastname = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPassword = new TextBox();
            txtCfPassword = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnSave = new Button();
            btnClear = new Button();
            cboPosition = new ComboBox();
            lbEmailErr = new Label();
            lbPwdErr = new Label();
            lbCfPwdErr = new Label();
            lbMsg = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(361, 73);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(334, 27);
            txtEmail.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(299, 76);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 1;
            label1.Text = "อีเมล์:";
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(361, 125);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(334, 27);
            txtFirstname.TabIndex = 2;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(361, 183);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(334, 27);
            txtLastname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(313, 132);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 5;
            label2.Text = "ชื่อ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(278, 190);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 6;
            label3.Text = "นามสกุล:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 255);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 7;
            label4.Text = "ตำเเหน่ง:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(361, 317);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(334, 27);
            txtPassword.TabIndex = 8;
            // 
            // txtCfPassword
            // 
            txtCfPassword.Location = new Point(361, 374);
            txtCfPassword.Name = "txtCfPassword";
            txtCfPassword.Size = new Size(334, 27);
            txtCfPassword.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(278, 324);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 10;
            label5.Text = "รหัสผ่าน:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(248, 381);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 11;
            label6.Text = "ยืนยันรหัสผ่าน:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.Location = new Point(350, 488);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Cyan;
            btnClear.Location = new Point(550, 488);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 13;
            btnClear.Text = "เคลียร์";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // cboPosition
            // 
            cboPosition.FormattingEnabled = true;
            cboPosition.Location = new Point(361, 252);
            cboPosition.Name = "cboPosition";
            cboPosition.Size = new Size(334, 28);
            cboPosition.TabIndex = 14;
            // 
            // lbEmailErr
            // 
            lbEmailErr.AutoSize = true;
            lbEmailErr.Location = new Point(712, 80);
            lbEmailErr.Name = "lbEmailErr";
            lbEmailErr.Size = new Size(15, 20);
            lbEmailErr.TabIndex = 15;
            lbEmailErr.Text = "*";
            // 
            // lbPwdErr
            // 
            lbPwdErr.AutoSize = true;
            lbPwdErr.Location = new Point(712, 324);
            lbPwdErr.Name = "lbPwdErr";
            lbPwdErr.Size = new Size(15, 20);
            lbPwdErr.TabIndex = 16;
            lbPwdErr.Text = "*";
            // 
            // lbCfPwdErr
            // 
            lbCfPwdErr.AutoSize = true;
            lbCfPwdErr.Location = new Point(712, 377);
            lbCfPwdErr.Name = "lbCfPwdErr";
            lbCfPwdErr.Size = new Size(15, 20);
            lbCfPwdErr.TabIndex = 17;
            lbCfPwdErr.Text = "*";
            // 
            // lbMsg
            // 
            lbMsg.AutoSize = true;
            lbMsg.Location = new Point(165, 488);
            lbMsg.Name = "lbMsg";
            lbMsg.Size = new Size(15, 20);
            lbMsg.TabIndex = 18;
            lbMsg.Text = "*";
            // 
            // FrmAddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(1030, 669);
            Controls.Add(lbMsg);
            Controls.Add(lbCfPwdErr);
            Controls.Add(lbPwdErr);
            Controls.Add(lbEmailErr);
            Controls.Add(cboPosition);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtCfPassword);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtLastname);
            Controls.Add(txtFirstname);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Name = "FrmAddUser";
            Text = "FrmAddUser";
            Load += FrmAddUser_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Label label1;
        private TextBox txtFirstname;
        private TextBox txtLastname;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPassword;
        private TextBox txtCfPassword;
        private Label label5;
        private Label label6;
        private Button btnSave;
        private Button btnClear;
        private ComboBox cboPosition;
        private Label lbEmailErr;
        private Label lbPwdErr;
        private Label lbCfPwdErr;
        private Label lbMsg;
    }
}