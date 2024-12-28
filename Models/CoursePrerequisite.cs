namespace TechGuide.Models
{
    public class CoursePrerequisite
    {
        public int CourseID { get; set; }
        public int PrerequisiteID { get; set; }

        // Navigation properties
        public Course Course { get; set; }
        public Course Prerequisite { get; set; }
    }
}
