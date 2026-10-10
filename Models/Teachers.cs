namespace WestcoastEducation;

public class Teachers : Students
{
    public List<Teachers> Knowledge {get;set;} = [];
    public List<Teachers> TeacherCourses {get;set;} = [];
}
