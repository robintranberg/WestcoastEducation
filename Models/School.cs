namespace WestcoastEducation;

public class School
{
    public List<Course> Courses { get; set; } = [];
    public List<Person> People { get; set; } = [];

    public bool AddCourse(Course course)
    {
        if (course.EndDate <= course.StartDate)
        {
            return false;
        }

        foreach (Course c in Courses)
        {
            if (c.CourseNumber == course.CourseNumber)
            {
                return false;
            }
        }

        Courses.Add(course);
        return true;
    }
    public bool AddPerson(Person person)
    {
        if (!person.IsValidPersonalNumber())
        {
            return false;
        }

        People.Add(person);
        return true;
    }

    public List<Student> GetStudents()
    {
        List<Student> students = [];

        foreach (Person person in People)
        {
            if (person is Student student)
            {
                students.Add(student);
            }
        }

        return students;
    }
}
