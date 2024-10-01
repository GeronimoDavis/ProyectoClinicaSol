using System.Data.SqlClient;

namespace DataLayer
{
    public class DataBase
    {

        private static SqlConnection connection;

        public static SqlConnection connectDB()
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-7NSQ4UH;Initial Catalog=Clinic; User ID=sa; Password=1234");
            connection.Open();
            return connection;
        }

        public static void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
    }
}
