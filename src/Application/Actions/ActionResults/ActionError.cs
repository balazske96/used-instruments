namespace Application.Actions.ActionResults;

public class ActionError
{
    public string Title { get; set; }
    public string Description { get; set; }
    public ushort Code { get; set; }
    ActionError(
        string title,
        string description,
        ushort code
    )
    {
        Title = title;
        Description = description;
        Code = code;
    }
}