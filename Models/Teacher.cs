namespace WestcoastEducation;

public class Teacher : Person
{
    public string Expertise { get; set; } = "";
    public List<Course> Courses { get; set; } = [];

    public void AddCourse(Course course)
    {
        foreach (Course c in Courses)
        {
            if (c.CourseNumber == course.CourseNumber)
            {
                return;
            }
        }

        Courses.Add(course);
    }

    public override string ToString()
    {
        return base.ToString() + ", kunskapsområde: " + Expertise + ", antal kurser: " + Courses.Count;
    }
}