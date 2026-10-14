using Spectre.Console;
using WestcoastEducation;

public static class Prompts
{
    public static Course AskCourse()
    {
            Course course = new()
            {
                CourseNumber = Input.Text("Kursnummer:"),
                Title = Input.Text("Titel:"),
                DurationWeeks = Input.Number("Längd i veckor:"),
                StartDate = Input.Date("Startdatum"),
                EndDate = Input.Date("Slutdatum"),
                IsOnline = Input.YesNo("Är kursen på distans?")
            };
            return course;
    }

    public static Student AskStudent()
    {
        Student student = new();
        FillPerson(student);
        return student;
    }

    public static Teacher AskTeacher()
    {
        Teacher teacher = new();
        FillTeacher(teacher);
        return teacher;
    }

    public static EducationLeader AskEducationLeader()
    {
        EducationLeader leader = new();
        FillLeader(leader);
        return leader;
    }

    public static Administrator AskAdministrator()
    {
        Administrator admin = new();
        FillLeader(admin);
        return admin;
    }

    private static void FillPerson(Person person)
    {
        person.FirstName = Input.Text("Förnamn:");
        person.LastName = Input.Text("Efternamn:");
        person.PersonalNumber = Input.Text("Personnummer (10 eller 12 siffror):");
        person.PhoneNumber = Input.Text("Telefon:");
        person.Address.Street = Input.Text("Adress:");
        person.Address.PostalCode = Input.Text("Postnummer:");
        person.Address.City = Input.Text("Ort:");
    }

    private static void FillTeacher(Teacher teacher)
    {
        FillPerson(teacher);
        teacher.Expertise = Input.Text("Kunskapsområde:");
    }

    private static void FillLeader(EducationLeader leader)
    {
        FillTeacher(leader);
        leader.EmploymentDate = Input.Date("Anställningsdatum");
    }
}
