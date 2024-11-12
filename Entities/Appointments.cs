using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Appointments
    {
        public int ScheludeId { get; set; }
        public int Day { get; set; }
        public DateTime Time { get; set; }
        public int ProfessionalId { get; set; }

        public Appointments() { }

        public Appointments(int scheludeId, int day, DateTime time, int professionalId) 
        {
            ScheludeId = scheludeId;
            Day = day;
            Time = time;
            ProfessionalId = professionalId;
        }
    }
}
