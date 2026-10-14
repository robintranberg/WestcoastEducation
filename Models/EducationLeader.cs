namespace WestcoastEducation;

public class EducationLeader : Teacher
{
    public DateTime EmploymentDate { get; set; }

    public override string ToString()
    {
        return base.ToString() + ", anställd: " + EmploymentDate.ToString("yyyy-MM-dd");
    }
}
