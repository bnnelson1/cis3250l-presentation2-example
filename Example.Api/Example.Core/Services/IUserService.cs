using Example.Core.Dtos;

namespace Example.Core.Services;

public interface IUserService
{
    UserDto? GetUserByUsername(string username);
}