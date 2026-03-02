using Example.Data.Models;

namespace Example.Core.Dtos;

public record UserDto(int Id, string Username, string Email)
{
    public UserDto(User user) : this(user.Id, user.Username, user.Email) {}
}
