using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Schedules
    {
        public int ScheduleId { get; set; }
        public int Day {  get; set; }
        public TimeSpan Time { get; set; }
        public int ProfessionalID { get; set; }

        public Schedules() { }

        public Schedules(int scheduleId, int day, TimeSpan time, int professionalID) 
        {
            ScheduleId = scheduleId;
            Day = day;
            Time = time;
            ProfessionalID = professionalID;
        }
    }
}
