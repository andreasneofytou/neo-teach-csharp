using System.Collections.Generic;

namespace Teach.Models {
    public class CourseClass {
        public int CourseClassId { get; set; }
        public string Name { get; set; }
        public CourseLevel Level { get; set; }
        public CourseSubject Subject { get; set; }
        public IEnumerable<CourseSchedule> Schedule { get; set; }
    }
}
