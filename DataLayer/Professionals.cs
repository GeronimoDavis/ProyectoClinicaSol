using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataLayer
{
    public class Professionals
    {

        public static List<Entities.Professional> GetProfessionals()
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

        public static Professional GetProfessional(int id)
        {
            Professional professional = null;

            SqlConnection conn = DataBase.connectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT professionalId, lastName, firstName, dni, email, mobilePhone, specialtyId FROM Professionals WHERE professionalId = @id";
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                professional = new Professional(
                    Convert.ToInt32(dr["professionalId"]),
                    dr["lastName"].ToString(),
                    dr["firstName"].ToString(),
                    dr["dni"].ToString(),
                    dr["email"].ToString(),
                    dr["mobilePhone"].ToString(),
                    Convert.ToInt32(dr["specialtyId"])
                );
            }

            dr.Close();
            DataBase.CloseConnection(conn);

            return professional;
        }

        
        public static List<Professional> GetProfessionalsBySpecialty(int specialtyId)
        {
            List<Entities.Professional> professionals = new List<Entities.Professional>();

            SqlConnection conn = DataBase.connectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT professionalId, lastName, firstName, dni, email, mobilePhone, specialtyId " +
                              "FROM Professionals WHERE specialtyId = @specialtyId ORDER BY lastName";
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.AddWithValue("@specialtyId", specialtyId); // Asignamos el valor del specialtyId al parámetro

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) // Recorre cada fila de los resultados obtenidos.
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
