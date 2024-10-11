using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataLayer
{
    class Professionals
    {

        public List<Entities.Professional> GetProfessionals()
        {
            List<Entities.Professional> professionals = new List<Entities.Professional>();

            SqlConnection conn = DataBase.connectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT professionalId, lastName, firstName, dni, email, mobilePhone, specialtyId FROM Professionals ORDER BY lastName";
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                professionals.Add(new Professional(
                  Convert.ToInt32(dr["professionalId"]),
                  dr["lastName"].ToString(),
                  dr["firstName"].ToString(),
                  dr["dni"].ToString(),
                  dr["email"].ToString(),
                  dr["mobilePhone"].ToString(),
                  Convert.ToInt32(dr["specialtyId"])
                ));
            }

            dr.Close();
            DataBase.CloseConnection(conn);
            

            return professionals;

        }
    }
}
