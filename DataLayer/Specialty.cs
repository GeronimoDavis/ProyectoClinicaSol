using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataLayer
{
    class Specialty
    {
        public List<Entities.Specialty> GetSpecialties()
        {
            List<Entities.Specialty> specialties = new List<Entities.Specialty>();

            SqlConnection conn = DataBase.connectDB();

            SqlCommand cm = new SqlCommand();
            cm.CommandText = "SELECT specialtyId, specialtyName FROM Specialties ORDER BY specialtyName";
            cm.Connection = conn;
            cm.CommandType = System.Data.CommandType.Text;
            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                specialties.Add(new Entities.Specialty(Convert.ToInt32(dr[0]), dr[1].ToString()));
            }

            dr.Close();
            conn.Close();

            return specialties;
        }
    }
}
