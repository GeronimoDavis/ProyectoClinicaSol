using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer
{
    public class dataSchedules
    {
        public static List<Schedules> GetSchedules(int professionalId)
        {
            List<Schedules> schedules = new List<Schedules>();

            SqlConnection conn = DataBase.connectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT scheduleId, day, time, professionalId FROM Schedules WHERE professionalId = " + professionalId.ToString();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                schedules.Add(new Schedules(Convert.ToInt32(dr["scheduleId"]),Convert.ToInt32(dr["day"]), Convert.ToDateTime(dr["time"]), Convert.ToInt32(dr["professionalId"])));
            }

            dr.Close();
            DataBase.CloseConnection(conn);

            return schedules;
        }
        
        


    }
}
