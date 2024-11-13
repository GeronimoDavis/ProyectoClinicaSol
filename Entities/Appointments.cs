using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Appointments
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public DateTime Time { get; set; }
        public int ProfessionalId { get; set; }
        public bool Canceled { get; set; }
        public string Status { get; set; }

        public Appointments() { }

        public Appointments(int appointmentId, int patientId, DateTime time, int professionalId, bool canceled, string status) 
        {
            AppointmentId = appointmentId;
            PatientId = patientId;
            Time = time;
            ProfessionalId = professionalId;
            Canceled = canceled;
            Status = status;
        }
    }
}
