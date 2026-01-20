namespace Company_DB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvDepartment = new DataGridView();
            txtID = new TextBox();
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtDesc = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            txtemail = new TextBox();
            btnNew = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).BeginInit();
            SuspendLayout();
            // 
            // dgvDepartment
            // 
            dgvDepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartment.Location = new Point(12, 87);
            dgvDepartment.Name = "dgvDepartment";
            dgvDepartment.RowHeadersWidth = 51;
            dgvDepartment.Size = new Size(367, 367);
            dgvDepartment.TabIndex = 0;
            dgvDepartment.CellMouseUp += dgvDepartment_CellMouseUp;
            // 
            // txtID
            // 
            txtID.Location = new Point(504, 87);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(504, 141);
            txtName.Name = "txtName";
            txtName.Size = new Size(339, 27);
            txtName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(420, 94);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 3;
            label1.Text = "รหัสเเผนก";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(426, 144);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 4;
            label2.Text = "ชื่อเเผนก";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(504, 197);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(339, 183);
            txtDesc.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(426, 200);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 6;
            label3.Text = "หมายเหตุ";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(504, 418);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(339, 27);
            txtPhone.TabIndex = 7;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(504, 471);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(339, 27);
            txtemail.TabIndex = 8;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.Yellow;
            btnNew.Location = new Point(368, 546);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(139, 78);
            btnNew.TabIndex = 9;
            btnNew.Text = "เพิ่มใหม่";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.Location = new Point(569, 546);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(139, 78);
            btnSave.TabIndex = 10;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(784, 546);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(139, 78);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "ลบ";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(420, 418);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 12;
            label4.Text = "โทรศัพท์";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(420, 478);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 13;
            label5.Text = "อีเมล์";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 649);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(txtemail);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(txtDesc);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(dgvDepartment);
            Name = "Form1";
            Text = "จัดการข้อมูลเเผนก";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDepartment;
        private TextBox txtID;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private TextBox txtDesc;
        private Label label3;
        private TextBox txtPhone;
        private TextBox txtemail;
        private Button btnNew;
        private Button btnSave;
        private Button btnDelete;
        private Label label4;
        private Label label5;
    }
}
