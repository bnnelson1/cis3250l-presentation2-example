using Example.Core.Dtos;
using Example.Data.Models;
using Example.Data.Repositories;

namespace Example.Core.Services;

public class UserService(IUserRepository repository) : IUserService
{
    public UserDto? GetUserByUsername(string username)
    {
        if (string.IsNullOrWhiteSpace(username)) return null;
        
        var user = repository.GetUserByUsername(username);
        var dto = user is null ? null : new UserDto(user);

        return dto;
    }
}
