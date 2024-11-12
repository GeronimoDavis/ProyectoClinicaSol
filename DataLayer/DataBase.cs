using System.Data.SqlClient;

namespace DataLayer
{
    public class DataBase
    {

        private static SqlConnection connection;

        public static SqlConnection connectDB()
        {

            connection = new SqlConnection("Server=DESKTOP-HUN8S6O\\SQLEXPRESS;Database=Clinic;Integrated Security=True;");
            connection.Open();
            return connection;
        }

        public static void CloseConnection(SqlConnection con)
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
    }
}