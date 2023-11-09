using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_exam.Model
{
    public class ScheduleModel
    {
       
        public int ScheduleId { get; set; }
        public string Course { get; set; }
        public string DayOfWeek { get; set; }
        public string TimeSlot { get; set; }
        public int RoomNumber { get; set; }


        public string Teacher { get; set; } // викладач, який веде заняття
        public string Subject { get; set; } // предмет, який викладається

       

        public ScheduleModel(int scheduleId, string course, string dayOfWeek, string timeSlot, int roomNumber)
        {
            ScheduleId = scheduleId;
            Course = course;
            DayOfWeek = dayOfWeek;
            TimeSlot = timeSlot;
            RoomNumber = roomNumber;
        }
    }

}
