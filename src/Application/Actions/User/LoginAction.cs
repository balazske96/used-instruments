using Application.DTO.User;
using Application.Actions;
using Application.Services;
using Application.Actions.ActionResults;
using Application.Actions.ActionResults.User;

namespace Application.Actions.User;

class LoginAction : BaseUserAction
{
    private LoginDTO _loginDto;

    public LoginAction(IUserService userService, LoginDTO loginDto) : base(userService)
    {
        _loginDto = loginDto;
    }

    override public LoginActionResult Execute()
    {
        Domain.Entities.User user = _userService.findByIdentifier(_loginDto.Identifier);

        if (_loginDto.Password != null)
        {

        }

        return new LoginActionResult(null, new { message = "ok" });
    }
}