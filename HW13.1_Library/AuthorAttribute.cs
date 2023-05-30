namespace HW13._1_Library;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Interface)]
public class AuthorAttribute : Attribute
{
    public string AuthorName { get; set; }
    public DateTime DateOfCreate { get; set; }

    public AuthorAttribute(string authorName, string dateOfCreate)
    {
        AuthorName = authorName;

        if (DateTime.TryParse(dateOfCreate, out var date))
        {
            DateOfCreate = date;
        }
        else
        {
            DateOfCreate = DateTime.Now;
        }
    }

    public override string ToString()
    {
        return $"AuthorName: {AuthorName}, DateOfCreate: {DateOfCreate}";
    }
}