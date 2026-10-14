using Spectre.Console;
using WestcoastEducation;

public static class Display
{
    public static void ShowHeader()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("==============================");
        Console.WriteLine("     WestCoast Education");
        Console.WriteLine("==============================");
        Console.ResetColor();
        Console.WriteLine();
    }

    public static void ShowSuccess(string text)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(text);
        Console.ResetColor();
    }

    public static void ShowError(string text)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(text);
        Console.ResetColor();
    }

    public static void ShowResult(bool success, string what)
    {
        if (success)
        {
            ShowSuccess(what + " lades till.");
        }
        else
        {
            ShowError("Kunde inte lägga till " + what.ToLower() + ". Kontrollera uppgifterna.");
        }
    }

    public static void ShowCourses(List<Course> courses)
    {
        if (courses.Count == 0)
        {
            Console.WriteLine("Inga kurser tillagda än.");
            return;
        }

        Console.WriteLine("Nr".PadRight(10) + "Titel".PadRight(25) + "Veckor".PadRight(8) +
                          "Start".PadRight(12) + "Slut".PadRight(12) + "Typ");
        Console.WriteLine(new string('-', 75));

        foreach (Course c in courses)
        {
            string type = "Klassrum";
            if (c.IsOnline)
            {
                type = "Distans";
            }

            Console.WriteLine(c.CourseNumber.PadRight(10) + c.Title.PadRight(25) +
                              c.DurationWeeks.ToString().PadRight(8) +
                              c.StartDate.ToString("yyyy-MM-dd").PadRight(12) +
                              c.EndDate.ToString("yyyy-MM-dd").PadRight(12) + type);
        }
    }

    public static void ShowStudents(List<Student> students)
    {
        if (students.Count == 0)
        {
            Console.WriteLine("Inga studerande tillagda än.");
            return;
        }

        Console.WriteLine("Namn".PadRight(25) + "Personnummer".PadRight(15) +
                          "Telefon".PadRight(15) + "Adress");
        Console.WriteLine(new string('-', 80));

        foreach (Student s in students)
        {
            Console.WriteLine((s.FirstName + " " + s.LastName).PadRight(25) +
                              s.PersonalNumber.PadRight(15) +
                              s.PhoneNumber.PadRight(15) +
                              s.Address.ToString());
        }
    }
}