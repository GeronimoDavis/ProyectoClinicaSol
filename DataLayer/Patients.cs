﻿using System;
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

        public static Patient getPatient(string dni) 
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
        public static void editarEstatus(int patientId, bool newStatus)
        {
            using(SqlConnection conn = DataBase.connectDB())
            {
                string query = @"UPDATE Patients 
                         SET status = @status 
                         WHERE patientId = @patientId"; // Consulta SQL para actualizar solo el campo 'status' del paciente que coincida con el patientid


                using (SqlCommand cmd = new SqlCommand(query, conn)) 
                {

                    cmd.Parameters.AddWithValue("@status", newStatus); // Asignamos el valor de 'newStatus' al parámetro @status en la consulta
                    cmd.Parameters.AddWithValue("@patientId", patientId); //indica qué registro debe actualizarse basándose en el valor de patientid


                    cmd.ExecuteNonQuery();

                }
            }

        }

        public static void EditPatient(Patient patient)
        {
            using (SqlConnection conn = DataBase.connectDB())
            {
                string query = @"UPDATE Patients 
                         SET lastName = @lastName, 
                             firstName = @firstName, 
                             medicalRecordNumber = @medicalRecordNumber, 
                             dni = @dni, 
                             birthDate = @birthDate, 
                             phone = @phone, 
                             mobilePhone = @mobilePhone, 
                             notes = @notes 
                         WHERE patientId = @patientId";

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
                    cmd.Parameters.AddWithValue("@patientId", patient.patientId);

                    cmd.ExecuteNonQuery();//actualiza el registro que coincide con el patientId y cambia únicamente el campo status al valor newStatus
                }
            }
        }

        public static void DeletePatient(int patientId) 
        { 
            using(SqlConnection conn = DataBase.connectDB())
            {
                string query = @"DELETE FROM Patients WHERE patientId = @patientId";

                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@patientId", patientId);

                    cmd.ExecuteNonQuery();
                }
            }
        
        }
    }
}