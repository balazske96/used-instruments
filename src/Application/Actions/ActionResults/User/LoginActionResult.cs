namespace Application.Actions.ActionResults.User;

class LoginActionResult : BaseActionResult
{
    public LoginActionResult(List<ActionError>? errors, object data): base(errors, data)
    {
    }
}