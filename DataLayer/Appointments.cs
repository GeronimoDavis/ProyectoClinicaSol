using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entities;
using System.Security.Cryptography.X509Certificates;

namespace DataLayer
{
    public class Appointments
    {
        public static void CreateAppointment(Appointment appointment) 
        {
            using (SqlConnection conn = DataBase.connectDB()) 
            {
                string query = @"INSERT INTO Appointments (AppointmentId, PatientId, Time, ProfessionalId, Canceled, Status) 
                                VALUES (@AppointmentId, @PatientId, @Time, @ProfessionalId, @Canceled, @Status)";

                using (SqlCommand cmd = new SqlCommand(query, conn)) 
                {
                    cmd.Parameters.AddWithValue("@AppointmentId", appointment.AppointmentId);
                    cmd.Parameters.AddWithValue("@PatientId", appointment.PatientId);
                    cmd.Parameters.AddWithValue("@Time", appointment.Time);
                    cmd.Parameters.AddWithValue("@ProfessionalId", appointment.ProfessionalId);
                    cmd.Parameters.AddWithValue("@Canceled", appointment.Canceled);
                    cmd.Parameters.AddWithValue("@Status", appointment.Status);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static List<Appointment> GetAppointments(int idPaciente) 
        {
            SqlConnection conn = DataBase.connectDB();

            SqlCommand cmd= new SqlCommand();

            List<Appointment> appointments = new List<Appointment>();

            cmd.CommandText = "SELECT appointmentId, patientId, dateTime, professionalId, canceled, status FROM Appointments WHERE patientId = " + idPaciente.ToString();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                appointments.Add(new Appointment(Convert.ToInt32(dr["appointmentId"]), Convert.ToInt32(dr["patientId"]), Convert.ToDateTime(dr["dateTime"]), Convert.ToInt32(dr["professionalId"]), Convert.ToBoolean(dr["canceled"]), Convert.ToString(dr["status"])));

            }

            dr.Close();
            DataBase.CloseConnection(conn);


            return appointments;
        }



    }
}
