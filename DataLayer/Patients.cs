using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataLayer
{
    public class Patients
    {
        public static void CreatePatient(Patient patient)
        {
            using (SqlConnection conn = DataBase.connectDB())
            {
                string query = @"INSERT INTO Patients (lastName, firstName, medicalRecordNumber, dni, birthDate, phone, mobilePhone, notes, status) 
                                VALUES (@lastName, @firstName, @medicalRecordNumber, @dni, @birthDate, @phone, @mobilePhone, @notes, @status)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@lastName", patient.lastName);
                    cmd.Parameters.AddWithValue("@firstName", patient.firstName);
                    cmd.Parameters.AddWithValue("@medicalRecordNumber", patient.medicalRecordNumber);
                    cmd.Parameters.AddWithValue("@dni", patient.dni);
                    cmd.Parameters.AddWithValue("@birthDate", patient.birthDate);
                    cmd.Parameters.AddWithValue("@phone", patient.phone);
                    cmd.Parameters.AddWithValue("@mobilePhone", patient.mobilePhone);
                    cmd.Parameters.AddWithValue("@notes", patient.notes);
                    cmd.Parameters.AddWithValue("@status", patient.status);

                    //conn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Entities.Patient> GetPatients()
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

        public static Patient getPatient(int dni) 
        {
            SqlConnection conn = DataBase.connectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT patientId, lastName, firstName, medicalRecordNumber, dni, birthDate, phone, mobilePhone, notes, status FROM Patients WHERE dni = "+ dni + "ORDER BY lastName";
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            Patient patient = new Patient();
            while (dr.Read()) 
            {
                patient.patientId = Convert.ToInt32(dr[0]);
                patient.lastName = Convert.ToString(dr[1]);
                patient.firstName = Convert.ToString(dr[2]);
                patient.medicalRecordNumber = Convert.ToInt32(dr[3]);
                patient.dni = Convert.ToString(dr[4]);
                patient.birthDate = Convert.ToDateTime(dr[5]);
                patient.phone = Convert.ToString(dr[6]);
                patient.mobilePhone = Convert.ToString(dr[7]);
                patient.notes = Convert.ToString(dr[8]);
                patient.status = Convert.ToBoolean(dr[9]);

            
            
            }
            dr.Close();
            DataBase.CloseConnection(conn);

            return patient;
        }
    }
}