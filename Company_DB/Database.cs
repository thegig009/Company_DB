using Microsoft.Data.SqlClient;

namespace Company_DB
{
	internal class Database
	{
		public static SqlConnection connectDBExample()
		{
			string connStr =
				@"Data Source=LAPTOP-KQD15JTK\SQLEXPRESS;Initial Catalog=Company_DB;Integrated Security=True";

			SqlConnection conn = new SqlConnection(connStr);
			conn.Open();
			return conn;
		}
	}
}
