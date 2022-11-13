using Domain.Entities;

namespace Application.Services;

interface IUserService
{
    public User findByIdentifier(string identifier);
}