namespace WCS.Domain;

public class Team
{
    public string Name { get; }

    public Team(string name)
    {
        if (name == null)
        {
            throw new ArgumentException("Name should be provided");
        }

        if (name == string.Empty)
        {
            throw new ArgumentException("Name should not be empty");
        }

        if (name.Length > 100)
        {
            throw new ArgumentException("Name should not be longer than 100 symbols");
        }
        
        Name = name;
    }
}