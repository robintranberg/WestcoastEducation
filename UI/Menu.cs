using Spectre.Console;
using WestcoastEducation;

public class Menu
{
    private School school = new School();
    private ICourseStorage storage = new JsonCourseStorage("courses.json");

    public void Run()
    {
        bool running = true;

        while (running)
        {
            ShowMenu();
            string choice = Console.ReadLine() ?? "";
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    Display.ShowResult(school.AddCourse(Prompts.AskCourse()), "Kursen");
                    break;
                case "2":
                    AddPerson(Prompts.AskTeacher(), "Läraren");
                    break;
                case "3":
                    AddPerson(Prompts.AskStudent(), "Studenten");
                    break;
                case "4":
                    AddPerson(Prompts.AskEducationLeader(), "Utbildningsledaren");
                    break;
                case "5":
                    AddPerson(Prompts.AskAdministrator(), "Administratören");
                    break;
                case "6":
                    Display.ShowCourses(school.Courses);
                    break;
                case "7":
                    Display.ShowStudents(school.GetStudents());
                    break;
                case "8":
                    storage.Save(school.Courses);
                    Display.ShowSuccess("Kurserna sparades i courses.json.");
                    break;
                case "9":
                    school.Courses = storage.Load();
                    Display.ShowSuccess("Läste in " + school.Courses.Count + " kurser.");
                    break;
                case "0":
                    running = false;
                    break;
                default:
                    Display.ShowError("Ogiltigt val, välj en siffra i menyn.");
                    break;
            }

            if (running)
            {
                Console.WriteLine("\nTryck på valfri tangent för att gå tillbaka...");
                Console.ReadKey(true);
            }
        }
    }

    private void ShowMenu()
    {
        Display.ShowHeader();
        Console.WriteLine("1. Lägg till kurs");
        Console.WriteLine("2. Lägg till lärare");
        Console.WriteLine("3. Lägg till studerande");
        Console.WriteLine("4. Lägg till utbildningsledare");
        Console.WriteLine("5. Lägg till administratör");
        Console.WriteLine("6. Lista kurser");
        Console.WriteLine("7. Lista studenter");
        Console.WriteLine("8. Spara kurser (JSON)");
        Console.WriteLine("9. Läs in kurser (JSON)");
        Console.WriteLine("0. Avsluta");
        Console.WriteLine();
        Console.Write("Välj: ");
    }

    private void AddPerson(Person person, string who)
    {
        Display.ShowResult(school.AddPerson(person), who);
    }
}