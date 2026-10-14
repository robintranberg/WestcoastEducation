namespace WestcoastEducation;

public interface ICourseStorage
{
    void Save(List<Course> courses);
    List<Course> Load();
}
