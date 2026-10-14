namespace WestcoastEducation;

public class Course
{
    public string CourseNumber { get; set; } = "";
    public string Title { get; set; } = "";
    public int DurationWeeks { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsOnline { get; set; }

    public override string ToString()
    {
        string type = "klassrum";
        if (IsOnline)
        {
            type = "distans";
        }

        return CourseNumber + " " + Title + ", " + DurationWeeks + " veckor, " +
               StartDate.ToString("yyyy-MM-dd") + " till " + EndDate.ToString("yyyy-MM-dd") + ", " + type;
    }
}
