using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;

namespace Company_DB
{
    public partial class Form1 : Form
    {
		// 🔹 Connection String (แทน DBConnect.cs)
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

        // 🔹 โหลดข้อมูล


        // 🔹 แสดงข้อมูลทั้งหมด
        void ShowAllDepartment()
        {
            conn = new SqlConnection(connStr);
            conn.Open();

            da = new SqlDataAdapter("SELECT * FROM Department", conn);
            dt = new DataTable();
            da.Fill(dt);

            dgvDepartment.DataSource = dt;
            conn.Close();
        }

        // 🔹 เพิ่มข้อมูล (Transaction + Store Procedure)
        void InsertRecord()
        {
            conn = new SqlConnection(connStr);
            conn.Open();
            SqlTransaction tr = conn.BeginTransaction();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_InsertDepartment", conn, tr);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@desc", txtDesc.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.ExecuteNonQuery();

                tr.Commit();
            }
            catch
            {
                tr.Rollback();
            }

            conn.Close();
        }

        // 🔹 แก้ไขข้อมูล
        void Update_Record()
        {
            conn = new SqlConnection(connStr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_UpdateDepartment", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@desc", txtDesc.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@fax", txtemail.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        // 🔹 ลบข้อมูล
        void DeleteRecord()
        {
            conn = new SqlConnection(connStr);
            conn.Open();

            SqlCommand cmd = new SqlCommand(
                "DELETE FROM Department WHERE DeptID=@id", conn);
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        // 🔹 ปุ่มบันทึก

        // 🔹 ปุ่มลบ


        // 🔹 คลิก DataGrid

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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRecord();
            ShowAllDepartment();
        }

        private void dgvDepartment_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
			txtID.Text = dgvDepartment.Rows[e.RowIndex].Cells[0].Value.ToString();
			txtName.Text = dgvDepartment.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtDesc.Text = dgvDepartment.Rows[e.RowIndex].Cells[2].Value.ToString();
			txtPhone.Text = dgvDepartment.Rows[e.RowIndex].Cells[3].Value.ToString();
			txtemail.Text = dgvDepartment.Rows[e.RowIndex].Cells[4].Value.ToString();
		}
    }
}
