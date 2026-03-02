using Example.Data.Models;
using Example.Data.Repositories;

namespace Example.Core.Services;

public class UserService(IUserRepository repository) : IUserService
{
    public User? GetUserByUsername(string username)
    {
        if (string.IsNullOrWhiteSpace(username)) return null;

        return repository.GetUserByUsername(username);
    }
}
