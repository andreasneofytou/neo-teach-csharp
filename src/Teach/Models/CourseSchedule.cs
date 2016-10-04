using System;
using System.Collections.Generic;

namespace Teach.Models {
    public class CourseSchedule {
        public int CourseScheduleId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public User Teacher { get; set; }
        public Classroom Classroom { get; set; }
        public IEnumerable<ScheduleDay> Days { get; set; }

    }
}
