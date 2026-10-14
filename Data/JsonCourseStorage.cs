namespace WestcoastEducation;

using System.Text.Json;

public class JsonCourseStorage(string path) : ICourseStorage
{
    private readonly string _path = path;

    public void Save(List<Course> courses)
    {
        JsonSerializerOptions options = new()
        {
            WriteIndented = true
        };

        string json = JsonSerializer.Serialize(courses, options);
        File.WriteAllText(_path, json);
    }

    public List<Course> Load()
    {
        if (!File.Exists(_path))
        {
            return [];
        }

        string json = File.ReadAllText(_path);
        List<Course>? courses = JsonSerializer.Deserialize<List<Course>>(json);

        if (courses == null)
        {
            return [];
        }

        return courses;
    }
}
