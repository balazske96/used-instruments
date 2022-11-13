namespace Application.Actions.ActionResults;

public abstract class BaseActionResult
{
    public List<ActionError>? Errors { get; set; }
    public object? Data { get; set; }

    protected BaseActionResult(List<ActionError>? errors, object data)
    {
        Errors = errors;
        Data = data;
    }
}