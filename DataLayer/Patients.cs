using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataLayer
{
    internal class Patients
    {

        public List<Entities.Patient> GetPatients()
        {
            List<Entities.Patient> patients = new List<Entities.Patient>();

            SqlConnection conn = DataBase.connectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT patientId, lastName, firstName, medicalRecordNumber, dni, birthDate, phone, mobilePhone, notes, status FROM Patients ORDER BY lastName";
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                patients.Add(new Patient(
                  Convert.ToInt32(dr["patientId"]),
                  dr["lastName"].ToString(),
                  dr["firstName"].ToString(),
                  Convert.ToInt32(dr["medicalRecordNumber"]),
                  dr["dni"].ToString(),
                  Convert.ToDateTime(dr["birthDate"]),
                  dr["phone"].ToString(),
                  dr["mobilePhone"].ToString(),
                  dr["notes"].ToString(),
                  Convert.ToBoolean(dr["status"])
                ));

            }

            dr.Close();
            DataBase.CloseConnection(conn);

            return patients;

        }
    }
}