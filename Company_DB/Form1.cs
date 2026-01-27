using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Company_DB
{
	public partial class Form1 : Form
	{
		string connStr = @"Data Source=LAPTOP-KQD15JTK\SQLEXPRESS;
                           Initial Catalog=Company_DB;
                           Integrated Security=True;
                           TrustServerCertificate=True;";

		SqlConnection conn;
		SqlDataAdapter da;
		DataTable dt;

		public Form1()
		{
			InitializeComponent();
		}

		
		void ShowAllDepartment()
		{
			using (conn = new SqlConnection(connStr))
			{
				da = new SqlDataAdapter("SELECT * FROM Department", conn);
				dt = new DataTable();
				da.Fill(dt);
				dgvDepartment.DataSource = dt;
			}
		}

		
		void InsertRecord()
		{
			using (conn = new SqlConnection(connStr))
			{
				conn.Open();
				SqlTransaction tr = conn.BeginTransaction();

				try
				{
					string sql = @"INSERT INTO Department
                                   (DeptName, DeptDesc, Phone, Email)
                                   VALUES (@name, @desc, @phone, @email)";

					SqlCommand cmd = new SqlCommand(sql, conn, tr);
					cmd.Parameters.AddWithValue("@name", txtName.Text);
					cmd.Parameters.AddWithValue("@desc", txtDesc.Text);
					cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
					cmd.Parameters.AddWithValue("@email", txtemail.Text);

					cmd.ExecuteNonQuery();
					tr.Commit();

					MessageBox.Show("เพิ่มข้อมูลเรียบร้อย ✅");
				}
				catch (Exception ex)
				{
					tr.Rollback();
					MessageBox.Show("เพิ่มข้อมูลไม่สำเร็จ ❌\n" + ex.Message);
				}
			}
		}

		void Update_Record()
		{
			using (conn = new SqlConnection(connStr))
			{
				conn.Open();
				SqlTransaction tr = conn.BeginTransaction();

				try
				{
					string sql = @"UPDATE Department SET
                                   DeptName = @name,
                                   DeptDesc = @desc,
                                   Phone = @phone,
                                   Email = @email
                                   WHERE DeptID = @id";

					SqlCommand cmd = new SqlCommand(sql, conn, tr);
					cmd.Parameters.AddWithValue("@id", int.Parse(txtID.Text));
					cmd.Parameters.AddWithValue("@name", txtName.Text);
					cmd.Parameters.AddWithValue("@desc", txtDesc.Text);
					cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
					cmd.Parameters.AddWithValue("@email", txtemail.Text);

					cmd.ExecuteNonQuery();
					tr.Commit();

					MessageBox.Show("อัปเดตข้อมูลเรียบร้อย ✅");
				}
				catch (Exception ex)
				{
					tr.Rollback();
					MessageBox.Show("อัปเดตไม่สำเร็จ ❌\n" + ex.Message);
				}
			}
		}

		
		void DeleteRecord()
		{
			using (conn = new SqlConnection(connStr))
			{
				conn.Open();
				string sql = "DELETE FROM Department WHERE DeptID=@id";
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@id", int.Parse(txtID.Text));
				cmd.ExecuteNonQuery();

				MessageBox.Show("ลบข้อมูลเรียบร้อย 🗑");
			}
		}

	
		void ClearText()
		{
			txtID.Clear();
			txtName.Clear();
			txtDesc.Clear();
			txtPhone.Clear();
			txtemail.Clear();
		}

	
		private void Form1_Load(object sender, EventArgs e)
		{
			ShowAllDepartment();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (txtID.Text == "")
				InsertRecord();
			else
				Update_Record();

			ShowAllDepartment();
			ClearText();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			DeleteRecord();
			ShowAllDepartment();
			ClearText();
		}

		private void dgvDepartment_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex < 0) return;

			txtID.Text = dgvDepartment.Rows[e.RowIndex].Cells[0].Value.ToString();
			txtName.Text = dgvDepartment.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtDesc.Text = dgvDepartment.Rows[e.RowIndex].Cells[2].Value.ToString();
			txtPhone.Text = dgvDepartment.Rows[e.RowIndex].Cells[3].Value.ToString();
			txtemail.Text = dgvDepartment.Rows[e.RowIndex].Cells[4].Value.ToString();
		}
	}
}
