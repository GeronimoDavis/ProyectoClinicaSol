using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Schedules
    {
        public int ScheduleId { get; set; }
        public int Day {  get; set; }
        public DateTime Time { get; set; }
        public int ProfessionalID { get; set; }

        public Schedules() { }

        public Schedules(int scheduleId, int day, DateTime time, int professionalID) 
        {
            ScheduleId = scheduleId;
            Day = day;
            Time = time;
            ProfessionalID = professionalID;
        }
    }
}
