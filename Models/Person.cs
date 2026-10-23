namespace WestcoastEducation;

public class Person
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string PersonalNumber { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public Address Address { get; set; } = new();

    // Villkor och loop
    public bool IsValidPersonalNumber()
    {
        if (PersonalNumber.Length != 10 && PersonalNumber.Length != 12)
        {
            return false;
        }

        foreach (char c in PersonalNumber)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }

        return true;
    }

    public override string ToString()
    {
        return FirstName + " " + LastName + ", " + PersonalNumber + ", tel: " + PhoneNumber + ", " + Address;
    }
}
