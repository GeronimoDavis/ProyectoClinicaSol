using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entities;

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

    }
}
