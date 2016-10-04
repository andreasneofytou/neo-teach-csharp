using System;

namespace Teach.Models {
    public class ScheduleDay
    {
        public int ScheduleDayId { get; set; }
        public string Name { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndtTime { get; set; }
    }
}
