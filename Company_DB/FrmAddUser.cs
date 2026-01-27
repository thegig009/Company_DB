using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Company_DB
{
    public partial class FrmAddUser : Form
    {
        public FrmAddUser()
        {
            InitializeComponent();
        }


        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            setPosition();
            clearForm();

            txtPassword.PasswordChar = '*';
            txtCfPassword.PasswordChar = '*';
        }


        public int addNewUser()
        {
            SqlConnection conn = Database.connectDBExample();


            SqlCommand cmd = new SqlCommand("AddUser_Transaction", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@userID", txtEmail.Text);
            cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text);
            cmd.Parameters.AddWithValue("@lastname", txtLastname.Text);
            cmd.Parameters.AddWithValue("@position", cboPosition.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);

            SqlParameter result = new SqlParameter("@Result", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            cmd.Parameters.Add(result);

            cmd.ExecuteNonQuery();
            conn.Close();

            return Convert.ToInt32(result.Value);
        }


        private void setPosition()
        {
            cboPosition.Items.Clear();
            cboPosition.Items.Add("Admin");
            cboPosition.Items.Add("User");
            cboPosition.Items.Add("Manager");
            cboPosition.Items.Add("IT Developer");
            cboPosition.SelectedIndex = 0;
        }


        private void clearForm()
        {
            txtEmail.Text = "";
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtPassword.Text = "";
            txtCfPassword.Text = "";

            lbMsg.Text = "";
            lbEmailErr.Text = "";
            lbPwdErr.Text = "";
            lbCfPwdErr.Text = "";
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            lbEmailErr.Text = "";
            lbPwdErr.Text = "";
            lbCfPwdErr.Text = "";
            lbMsg.Text = "";

            if (txtEmail.Text == "")
            {
                lbEmailErr.Text = "*";
                isValid = false;
            }

            if (txtPassword.Text == "")
            {
                lbPwdErr.Text = "*";
                isValid = false;
            }

            if (txtPassword.Text != txtCfPassword.Text)
            {
                lbCfPwdErr.Text = "*";
                isValid = false;
            }

            if (isValid)
            {
                int result = addNewUser();

                if (result == 1)
                {
                    lbMsg.Text = "บันทึกข้อมูลสำเร็จ";
                    clearForm();
                }
                else
                {
                    lbMsg.Text = "Email ซ้ำ ไม่สามารถบันทึกได้";
                }
            }
        }


        private void BtnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void FrmAddUser_Load_1(object sender, EventArgs e)
        {
            setPosition();
            clearForm();

            txtPassword.PasswordChar = '*';
            txtCfPassword.PasswordChar = '*';
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
			bool isValid = true;

			lbEmailErr.Text = "";
			lbPwdErr.Text = "";
			lbCfPwdErr.Text = "";
			lbMsg.Text = "";

			if (txtEmail.Text == "")
			{
				lbEmailErr.Text = "*";
				isValid = false;
			}

			if (txtPassword.Text == "")
			{
				lbPwdErr.Text = "*";
				isValid = false;
			}

			if (txtPassword.Text != txtCfPassword.Text)
			{
				lbCfPwdErr.Text = "*";
				isValid = false;
			}

			if (isValid)
			{
				int result = addNewUser();

				if (result == 1)
				{
					lbMsg.Text = "บันทึกข้อมูลสำเร็จ";
					clearForm();
				}
				else
				{
					lbMsg.Text = "Email ซ้ำ ไม่สามารถบันทึกได้";
				}
			}
		}
	}
    }
