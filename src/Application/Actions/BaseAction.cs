using Application.Actions.ActionResults;

namespace Application.Actions;

abstract class BaseAction
{
    abstract public BaseActionResult Execute();
}