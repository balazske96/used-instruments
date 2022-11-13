
using Application.Actions;
using Application.Services;

abstract class BaseUserAction : BaseAction
{
    protected IUserService _userService;

    public BaseUserAction(IUserService userService)
    {
        _userService = userService;
    }
}