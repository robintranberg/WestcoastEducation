namespace WestcoastEducation;

public static class Input
{
    public static string Text(string question)
    {
        string answer = "";

        while (answer.Trim() == "")
        {
            Console.Write(question + " ");
            answer = Console.ReadLine() ?? "";
        }

        return answer.Trim();
    }

    public static int Number(string question)
    {
        int number;

        Console.Write(question + " ");
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Display.ShowError("Skriv ett heltal.");
            Console.Write(question + " ");
        }

        return number;
    }

    public static DateTime Date(string question)
    {
        DateTime date;

        Console.Write(question + " (åååå-mm-dd): ");
        while (!DateTime.TryParse(Console.ReadLine(), out date))
        {
            Display.ShowError("Skriv ett giltigt datum, till exempel 2026-10-11.");
            Console.Write(question + " (åååå-mm-dd): ");
        }

        return date;
    }

    public static bool YesNo(string question)
    {
        while (true)
        {
            Console.Write(question + " (j/n): ");
            string answer = (Console.ReadLine() ?? "").Trim().ToLower();

            if (answer == "j")
            {
                return true;
            }

            if (answer == "n")
            {
                return false;
            }

            Display.ShowError("Svara j eller n.");
        }
    }
}
