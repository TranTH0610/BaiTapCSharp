using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace QLCuaHang
{
    internal static class Db
    {
        // Tạo tham số SQL.
        internal static SqlParameter P(string name, object value)
        {
            return new SqlParameter(name, value);
        }

        // Thực hiện SELECT và trả về bảng dữ liệu.
        internal static DataTable Query(
            string sql,
            params SqlParameter[] args)
        {
            string connectionString =
                ConfigurationManager
                    .ConnectionStrings["QLCuaHang"]
                    .ConnectionString;

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            using (SqlCommand command =
                new SqlCommand(sql, connection))
            using (SqlDataAdapter adapter =
                new SqlDataAdapter(command))
            {
                command.Parameters.AddRange(args);

                DataTable table = new DataTable();

                adapter.Fill(table);

                return table;
            }
        }

        // Gọi stored procedure.
        // Nếu procedure có SELECT một giá trị thì nhận giá trị đó.
        internal static object Run(
            string procedure,
            params SqlParameter[] args)
        {
            string connectionString =
                ConfigurationManager
                    .ConnectionStrings["QLCuaHang"]
                    .ConnectionString;

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            using (SqlCommand command =
                new SqlCommand(procedure, connection))
            {
                command.CommandType =
                    CommandType.StoredProcedure;

                command.Parameters.AddRange(args);

                connection.Open();

                return command.ExecuteScalar();
            }
        }
    }
}